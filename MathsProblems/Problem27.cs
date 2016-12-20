using System.Collections.Generic;
using static MathsProblems.MathProblemsLibrary;

namespace MathsProblems
{
    internal class Problem27
    {
        internal const int digitConst = 1000;
        internal const long maxValue = 4000000; 
        internal static string Quadratic_primes()
        {
            long resultCount = 0;
            long MaxValue = 0;
            long result = 0;
            long digit = 0;
            var resultList = Primes.GetBelov(maxValue);
            resultList.Sort();
            
            for (long b = - digitConst; b <= digitConst; b++)
            {
                for (long a = - digitConst + 1; a <= digitConst - 1; a++)
                {
                    resultCount = 0;
                    for (long n = 0; true; n++)
                    {
                        digit = n * n + a * n + b;
                        if (digit > 0)
                        {
                            if (resultList.BinarySearch(digit) >= 0)
                                resultCount += 1;
                            else
                                break;
                        }
                    }
                    if (resultCount > MaxValue)
                    {
                        MaxValue = resultCount;
                        result = a * b;
                    }
                }
            }
            return result.ToString();
        }
    }
}