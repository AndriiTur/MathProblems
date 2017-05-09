using System;
using System.Collections.Generic;

namespace MathsProblems
{
    internal class Problem49
    {
        internal static string Prime_permutations()
        {
            var primeList = MathProblemsLibrary.Primes.GetBelov(10000);
            var reListPrime = new List<Int64> { };
            var reList = new List<long> { };
            var resultList = new List<long> { };
            string re = "";
            for (int i = 0; i < primeList.Count; i++)
            {
                if (primeList[i] > 999)
                    reListPrime.Add(primeList[i]);
            }
            for (int i = 0; i < reListPrime.Count; i++)
            {
                reList.Clear();
                reList.Add(reListPrime[i]);
                for (int j = i + 1; j < reListPrime.Count; j++)
                {
                    if (Check_permutatiom(reListPrime[i].ToString(), reListPrime[j].ToString()))
                    {
                        
                        reList.Add(reListPrime[j]);
                        reListPrime.Remove(reListPrime[j]);
                    }
                }
                resultList = Check_Sum(reList);
                if (resultList.Count >= 3)
                {
                    for (int r = 0; r < resultList.Count; r++)
                    {
                        re += resultList[r].ToString();
                    }
                    MathsProblemsForm.Log(re);
                }
                re = "";
            }
            return "";
        }

        internal static bool Check_permutatiom(string val, string val2)
        {
            string subVal = val2;
            int index = 0;
            for (int i = 0; i < val.Length; i++)
            {
                index = subVal.IndexOf(val[i]);
                if (index < 0)
                    return false;
                subVal = subVal.Remove(index, 1);
            }
            return true;
        }

        internal static List<Int64> Check_Sum(List<Int64> resList)
        {
            List<Int64> resultList = new List<Int64> { };
            Int64 sum1 = 0;
            Int64 sum2 = 0;
            for (int i = resList.Count - 1; i >= 2; i--)
            {
                for (int j = i - 1; j >= 1; j--)
                {
                    sum1 = resList[i] - resList[j];
                    for (int k = j - 1; k >= 0; k--)
                    {
                        sum2 = resList[j] - resList[k];
                        if (sum2 == sum1)
                        {
                            resultList.Add(resList[k]);
                            resultList.Add(resList[j]);
                            resultList.Add(resList[i]);
                            return resultList;
                        }
                    }
                }
            }
            return resultList;
        }
    }
}