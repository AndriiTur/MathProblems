using System;
using System.Collections.Generic;

namespace MathsProblems
{
    internal class Problem41
    {
        public const int val = 10000000;

        internal static string Pandigital_prime()
        {
            Int64 maxVal = 0;
            List<Int64> listPrimes = MathProblemsLibrary.Primes.GetBelov(val);
            foreach (var primeVal in listPrimes)
            {
                if (Check_Pandigital_products(primeVal.ToString(), primeVal.ToString().Length)
                    && primeVal > maxVal)
                {
                    maxVal = primeVal;
                    //MathsProblemsForm.Log(primeVal.ToString());
                }
            }
            return maxVal.ToString();
        }

        internal static bool Check_Pandigital_products(string valStr,int rank)
        {
            string checkStr = "123456789";
            for (int i = 0; i < rank; i++)
            {
                if (valStr.IndexOf(checkStr[i]) < 0)
                    return false;

            }
            return true;

        }
    }
}