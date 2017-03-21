using System;
using static MathsProblems.MathProblemsLibrary;

namespace MathsProblems
{
    internal class Problem30
    {
        public const int degree = 5;

        internal static string Digit_fifth_powers()
        {
            string digits = "";
            int digitPower;
            int digit;
            int digitSumm = 0;
            int resultSumm = 0;
            for (int i = 2; i < 10000000; i++)
            {
                digitSumm = 0;
                digits = i.ToString();
                for (int j = digits.Length - 1; j >= 0; j--)
                {
                    digit = int.Parse(digits[j].ToString());
                    digitPower = (int)Math.Pow(digit, degree);

                    //result = int.Parse(LargeDigitsDestroyer.Degree_Numbers(digit, degree));
                    digitSumm += digitPower;
                }
                if (digitSumm == i)
                {
                    resultSumm += digitSumm;
                }
            }
            return resultSumm.ToString();
        }
    }
}