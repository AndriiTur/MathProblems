using System;
using static MathsProblems.MathProblemsLibrary;

namespace MathsProblems
{
    internal class Problem16
    {
        private const int step = 1000 ;

        internal static string Power_Digit_Sum()
        {
            string strTemp = "";
            int digits = 0;
            int digitsTemp = 0;

            strTemp =  LargeDigitsDestroyer.Power_Numbers(2, 1000);


            for (int k = strTemp.Length - 1; k >= 0; k--)
            {
                digits = Convert.ToInt32(strTemp[k].ToString());
                digitsTemp = digitsTemp + digits;

            }
            return digitsTemp.ToString();
        }

    }
}