using System.Collections.Generic;
using static MathsProblems.MathProblemsLibrary;

namespace MathsProblems
{

    internal class Problem10
    {
        public const int value = 2000000;
        internal static string Summation_of_primes()
        {
            long sum = 0;
            var resultList = new List<long>();
            for (long i = 2; i <= value; i++)
            {
                if (!Primes.HasMultiplier(i, resultList))
                    resultList.Add(i);
            }
            foreach (long val in resultList)
            {
                sum = sum + val;
            }
            return sum.ToString();
        }
    }

}