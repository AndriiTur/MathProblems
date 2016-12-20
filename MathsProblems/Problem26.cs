using System.Collections.Generic;
using static MathsProblems.MathProblemsLibrary;

namespace MathsProblems
{
    internal class Problem26
    {
        public static int d = 1000;
        internal static string Reciprocal_cycles()
        {
            int digit = 10;
            int reultMax = 0;
            string resultStr = "";
            string strDigit = "";
            for (int i = 2; i < d; i++)
            {
                strDigit = LargeDigitsDestroyer.DivisionOfNatural(digit, i);
                MathsProblemsForm.Log(i.ToString() + "\t" + strDigit);
                if (strDigit.Length > reultMax)
                {
                    reultMax = strDigit.Length;
                    resultStr = strDigit;
                }
            }
            return resultStr ;
        }
    }
}