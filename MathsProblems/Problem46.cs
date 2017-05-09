using System;
using System.Collections.Generic;

namespace MathsProblems
{
    internal class Problem46
    {
        internal static string Goldbachs_other_conjecture()
        {
            List<Int64> listPrimes = MathProblemsLibrary.Primes.GetBelov(6000);
            for (Int64 i = 9; i < int.MaxValue / 2; i = i + 2)
            {
                if (listPrimes.IndexOf(i) < 0)
                {
                    if (!Check_Goldbachs(i,listPrimes))
                        return i.ToString();
                }
            }
            return "";
        }

        internal static bool Check_Goldbachs(Int64 val,List<Int64> primeList)
        {

            for (int j = 0; j < primeList.Count; j++)
            {
                Int64 diference = val - primeList[j];
                if (diference < 0)
                    return false;

                var k = Math.Sqrt((Int64)(diference / 2));
                if (k == (Int64)k)
                    return true;
            }
            return false;
        }
    }
}