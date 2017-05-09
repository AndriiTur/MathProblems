using System.Collections.Generic;

namespace MathsProblems
{
    internal class Problem55
    {
        internal static string Lychrel_numbers()
        {
            int result = 0;
            for (int i = 1; i < 10000; i++)
            {
                string summ = "12";
                int count = 0;
                string val1 = i.ToString();

                while (!IsPalindrom(summ))
                {
                    string val2 = "";
                    List<char> vl2 = new List<char>();

                    foreach (var val in val1)
                        vl2.Insert(0, val);
                    foreach (var value in vl2)
                        val2 += value;

                    summ = MathProblemsLibrary.LargeDigitsDestroyer.Summ_Two_Huge_Digits(val1, val2);
                    count++;
                    //MathsProblemsForm.Log(val1 + "+" + val2 + "==" + summ);
                    if (count == 50)
                        break;
                    val1 = summ;
                }
                if (count == 50)
                {
                    result++;
                    MathsProblemsForm.Log(i.ToString() + "(" + count.ToString() + ")");
                }
            }
            return result.ToString();
        }

        internal static bool IsPalindrom(string digit)
        {
            int index = 0;
            while (index < digit.Length / 2)
            {
                if (digit[index] != digit[digit.Length - 1 - index])
                {
                    return false;
                }
                index++;
            }
            return true;
        }
    }
}