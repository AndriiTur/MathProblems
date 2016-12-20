using System.Collections.Generic;
using static MathsProblems.MathProblemsLibrary;

namespace MathsProblems
{

    internal class Problem7
    {
        internal static string st_prime()
        {
            var resultList = new List<long>();
            int elem = 2;
            while (resultList.Count < 10001)
            {
                if (!Primes.HasMultiplier(elem, resultList))
                {
                    resultList.Add(elem);
                    elem += 1;
                }
                else
                {
                    elem += 1;
                }
            }
            var result = resultList[resultList.Count - 1];
            return result.ToString();
        }
    }

}