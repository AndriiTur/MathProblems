using System.Collections.Generic;

namespace MathsProblems
{
    internal class Problem52
    {
        internal static string Permuted_multiples()
        {
            int tempDigit;
            for (int i = 1; i < int.MaxValue / 2; i++)
            {
                List<int> iVal = DigitsToList(i);
                int count = 1;

                for (int j = 2; j <= 6; j ++)
                {
                    tempDigit = i * j;
                    List<int> valDigit = DigitsToList(tempDigit);
                    if (!CheckedDigit(iVal, valDigit))
                        break;
                    else
                        count++;
                }
                if (count == 6)
                    return i.ToString();
            }
            return "";
        }

        internal static List<int> DigitsToList(int digit)
        {
            List<int> digitVal = new List<int>();
            do
            {
                digitVal.Add(digit % 10);
                digit = digit / 10;
            }
            while (digit >= 10);
            digitVal.Add(digit);

            return digitVal;
        }

        internal static bool CheckedDigit(List<int> digit, List<int> digitForCheck)
        {
            if (digit.Count != digitForCheck.Count)
                return false;

            for (int i = 0; i < digit.Count; i ++)
            {
                if (digitForCheck.IndexOf(digit[i]) == -1)
                    return false;
                else
                    digitForCheck.Remove(digit[i]);
            }

            return true;
        }
    }
}