using System.Collections.Generic;
using static MathsProblems.MathProblemsLibrary;

namespace MathsProblems
{
    internal class Problem29
    {
        public const int maxValue = 100;
        internal static string Distinct_powers()
        {
            List<string> result = new List<string>();
            string validate = "";

            for (int i = 2; i <= maxValue; i++)
            {
                for (int j = 2; j <= maxValue; j++)
                {
                    validate = LargeDigitsDestroyer.Degree_Numbers(i, j);
                    if (result.IndexOf(validate) < 0)
                        result.Add(validate);
                }
            }
            return result.Count.ToString();
        }
    }
}