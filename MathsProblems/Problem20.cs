using System;
using static MathsProblems.MathProblemsLibrary;

namespace MathsProblems
{
    internal class Problem20
    {
        public const int value = 100;
        internal static string Factorial_digit_sum()
        {
            string strTemp = "";
            int digits = 0;
            int digitsTemp = 0;

            strTemp = LargeDigitsDestroyer.Faktorial(100);


            for (int k = strTemp.Length - 1; k >= 0; k--)
            {
                digits = Convert.ToInt32(strTemp[k].ToString());
                digitsTemp = digitsTemp + digits;
            }
            return digitsTemp.ToString();
            
        }   
    }
}