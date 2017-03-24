using System;
using System.Collections.Generic;

namespace MathsProblems
{
    internal class Problem37
    {
        public const int maxVal = 1000000;

        internal static string Truncatable_primes()
        {
            List<Int64> primeList = MathProblemsLibrary.Primes.GetBelov(maxVal);
            Int64 sum = 0;
            for (int i = 4; i < primeList.Count; i++)
            {
                if (Val_In_List_Start(primeList[i], primeList) && Val_In_List_End(primeList[i], primeList))
                {
                    MathsProblemsForm.Log("Val =" + primeList[i].ToString());
                    sum += primeList[i];
                }
            }
            return sum.ToString();
        }

        internal static bool Val_In_List_Start(Int64 digit, List<Int64> primes)
        {
            string digitStr = digit.ToString();
            string resStr = "";
            //MathsProblemsForm.Log("Dig + " + digitStr);
            for (int j = 0; j < digitStr.Length; j++)
            {
                resStr = digitStr.Remove(0,1);
                digitStr = resStr;
                //MathsProblemsForm.Log("S + " + digitStr);
                if (primes.IndexOf(Int64.Parse(digitStr)) < 0)
                    return false;
                j = 0;
            }
            return true;
            
        }

        internal static bool Val_In_List_End(Int64 digit, List<Int64> primes)
        {
            string digitStr = digit.ToString();
            string resStr = "";
            //MathsProblemsForm.Log("dig + " + digitStr);
            for (int i = 0; i < digitStr.Length; i++)
            {
                if (digitStr.Length != 0)
                {
                    resStr = digitStr.Remove(digitStr.Length - 1);
                }
                    digitStr = resStr;
                //MathsProblemsForm.Log("E + " + digitStr);
                if (primes.IndexOf(Int64.Parse(digitStr)) < 0)
                        return false;
                i = 0;
            }
            return true;
        }
    }
}