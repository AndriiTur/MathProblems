using System;
using System.Collections.Generic;

namespace MathsProblems
{
    internal class Problem50
    {
        internal static string Consecutive_prime_sum()
        {
            List<Int64> primeList = MathProblemsLibrary.Primes.GetBelov(1000000);
            Dictionary<Int64, Int64> resValList = new Dictionary<Int64, Int64> { };
            Int64 maxVal = 0;
            Int64 val = 0;
            for (int i = 2; i < primeList.Count; i++)
            {
                int k = i;
                while (k >= 0)
                {
                    k--;
                    Int64 sum = 0;
                    int count = 0;
                    for (int j = k; j >= 0; j--)
                    {
                        sum += primeList[j];
                        count++;
                        if (sum >= primeList[i])
                            break;
                    }
                    if (sum == primeList[i] && count > maxVal)
                    {
                        val = primeList[i];
                        maxVal = count;
                        MathsProblemsForm.Log(val.ToString() + "    " + maxVal.ToString());
                    }
                }
            }
            return val.ToString();
        }
    }
}