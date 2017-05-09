using System.Collections.Generic;

namespace MathsProblems
{
    internal class Problem53
    {
        internal static string Combinatoric_selections()
        {
            string f1 = "";
            string f2 = "";
            string f3 = "";
            string sum = "";
            string divide = "";
            int count = 0;

            for (int n = 23; n <= 100; n ++)
            {
                for (int r = 1; r < n; r ++)
                {
                    f1 = MathProblemsLibrary.LargeDigitsDestroyer.Faktorial(n);
                    f2 = MathProblemsLibrary.LargeDigitsDestroyer.Faktorial(r);
                    f3 = MathProblemsLibrary.LargeDigitsDestroyer.Faktorial(n - r);
                    sum = MathProblemsLibrary.LargeDigitsDestroyer.Multiplication_Two_Huge_Digits(f2, f3);
                    divide = MathProblemsLibrary.LargeDigitsDestroyer.Divide_Two_Huge_Digits(f1, sum);
                    if (CheckDigit(divide,"1000000"))
                    {
                        MathsProblemsForm.Log(n.ToString() + "  " + r.ToString() + " = " + divide);
                        count++;
                    }
                }
            }
            return count.ToString();
        }

        internal static bool CheckDigit(string digit, string valForCheck)
        {
            if (digit.Length < valForCheck.Length)
                return false;
            if (digit.Length > valForCheck.Length)
                return true;
            if (digit.Length == valForCheck.Length)
            {
                List<int> dig = MathProblemsLibrary.LargeDigitsDestroyer.StringToList(digit);
                List<int> checkVal = MathProblemsLibrary.LargeDigitsDestroyer.StringToList(valForCheck);

                for (int i = 0; i < dig.Count; i++)
                {
                    if (dig[i] < checkVal[i])
                        return false;
                    if (dig[i] > checkVal[i])
                        return true;
                }
                return true;
            }
            else
                return false;
        }
    }
}