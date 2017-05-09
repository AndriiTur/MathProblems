using System;
using System.Text;

namespace MathsProblems
{
    internal class Problem48
    {
        internal static string Self_powers()
        {
            string reVal = "";
            string tempStr = "";
            for (int i = 1; i <= 1000; i++)
            {
                tempStr = MathProblemsLibrary.LargeDigitsDestroyer.Power_Numbers(i, i);
                reVal = MathProblemsLibrary.LargeDigitsDestroyer.Summ_Two_Huge_Digits(tempStr, reVal);
            }
            return reVal.ToString();
        }
    }
}