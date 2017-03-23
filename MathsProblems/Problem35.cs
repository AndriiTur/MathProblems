using System;
using System.Collections;
using System.Collections.Generic;

namespace MathsProblems
{
    internal class Problem35
    {
        public const int maxVal = 1000000;
        internal static string Circular_primes()
        {
            List<Int64> primeList = MathProblemsLibrary.Primes.GetBelov(maxVal);
            int count = 0;
            for (int i = 0; i < primeList.Count; i++)
            {
                if (Val_in_list(primeList[i], primeList))
                {
                    MathsProblemsForm.Log(primeList[i].ToString());
                    count++;
                }
            }
            return count.ToString();
        }

        internal static bool Val_in_list(Int64 digit,List<Int64> primes)
        {
            string digitStr = digit.ToString();
            string dig = "";
            string resStr = "";
            for (int j = 0; j < digitStr.Length - 1; j++)
            {
                dig = digitStr[digitStr.Length - 1].ToString();
                resStr = digitStr.Remove(digitStr.Length - 1);
                digitStr = dig + resStr;
                if (primes.IndexOf(Int64.Parse(digitStr)) < 0)
                    return false;
            }
            return true;
        }
    }
}