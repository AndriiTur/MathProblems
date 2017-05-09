using System;
using System.Collections.Generic;
using static MathsProblems.MathProblemsLibrary;

namespace MathsProblems
{
    internal class Problem47
    {
        internal static string Distinct_primes_factors()
        {
            Int64 i = 3;
            int count = 4;
            while (true)
            {
                for (var j = 0; j < count; j++)
                {
                    if (Problem47.HasUniquePrimes(i + j, count))
                    {
                        if (j == count - 1)
                            return i.ToString();
                    }
                    else
                    {
                        i += j + 1;
                        break;
                    }
                }
            }                
        }

        private static bool HasUniquePrimes(long value, int count)
        {
            var primeList = Divisors.GetPrimeListOfDivisors(value, true);
            if (primeList.Count >= count)
            {
                var uniquePrimeList = new List<Int64>();
                foreach (var i in primeList)
                {
                    if (uniquePrimeList.IndexOf(i) < 0)
                    {
                        uniquePrimeList.Add(i);
                        if (uniquePrimeList.Count == count)
                            return true;
                    }
                }

                return uniquePrimeList.Count == count;
            }
            return false;
        }

        internal static string Distinct_primes_factors2()
        {
            var listPrimes = MathProblemsLibrary.Primes.GetBelov(1000000);
            var divList = new List<Int64> { };
            var reList = new List<Int64> { };
            var dictResult = new Dictionary<Int64, bool> { };
            int tempRe = 1;
            for (Int64 i = 2; i < 1000000; i++)
            {
                divList = GetDivisors(i);
                reList.Clear();
                if (divList.Count == 4)
                {
                    foreach (var div in divList)
                    {
                        if ((listPrimes.IndexOf(div) >= 0 || Check_Degree(div) != 0) && reList.IndexOf(div) < 0)
                            reList.Add(div);
                    }
                    if (reList.Count == 4)
                    {
                        MathsProblemsForm.Log(i.ToString());
                        dictResult.Add(i, true);
                        if (dictResult.ContainsKey(i - 1))
                        {
                            tempRe += 1;
                            if (tempRe == 4)
                                return (i - 3).ToString();
                        }
                        else
                            tempRe = 1;
                    }

                }
                //divList = MathProblemsLibrary.Divisors.GetList(i,false);
                //listPrimes = MathProblemsLibrary.Primes.GetBelov(i);
                //reList.Clear();
                //foreach (var div in divList)
                //{

                //    if (listPrimes.IndexOf(div) >= 0)
                //        reList.Add(div);
                //    else
                //    {
                //        Int64 temp = Check_Degree(div);
                //        if (temp > 0 && reList.IndexOf(temp) < 0)
                //            reList.Add(div);
                //    }
                //}
                //sumary = 1;
                //foreach (var rel in reList)
                //{
                //    sumary = sumary * rel;
                //}
                //if ((reList.Count == 4) && (sumary == i))
                //{


                //    //string str = i.ToString() + " = ";
                //    //foreach (var rl in reList)
                //    //{
                //    //    str += rl.ToString() + " x ";
                //    //}
                //    //MathsProblemsForm.Log(str);



                //    dictResult.Add(i, true);
                //    if (dictResult.ContainsKey(i - 1))
                //    {
                //        MathsProblemsForm.Log(i.ToString());
                //        tempRe += 1;
                //        if (tempRe == 4)
                //            return (i - 3).ToString();
                //    }
                //    else
                //        tempRe = 1;
                //}




                ////var reList = new List<Int64> { };
                ////for (int j = 0; j < divList.Count; j++)
                ////{
                ////    if (reList.IndexOf(divList[j]) < 0)
                ////    {
                ////        reList.Add(divList[j]);
                ////    }
                ////}
                ////if (reList.Count != 4)
                ////{
                ////    string str = i.ToString() + "= ";
                ////    foreach (var rl in reList)
                ////    {
                ////        str += rl.ToString() + "x";
                ////    }
                ////    MathsProblemsForm.Log(str);
                ////    dictResult.Add(i, true);
                ////    if (dictResult.ContainsKey(i - 1))
                ////    {
                ////        tempRe += 1;
                ////        if (tempRe == 4)
                ////            return i.ToString();
                ////    }
                ////    else
                ////        tempRe = 1;
                ////}
            }
            return "";
        }

        internal static Int64 Check_Degree(Int64 val)
        {
            Int64 tmp = val;
            for (Int64 i = (Int64)Math.Sqrt(val); i < val; i++)
            {
                while (tmp > i)
                {
                    if (tmp % i != 0)
                        break;
                    else
                        tmp = tmp / i;
                }
                if (tmp == i)
                {
                    List<Int64> listPrimes = MathProblemsLibrary.Primes.GetBelov(val);
                    if (listPrimes[listPrimes.Count - 1] == i)
                        return i;
                }
            }
            return 0;
        }

        internal static List<Int64> GetDivisors(Int64 value)
        {
            var resultlist = new List<Int64>();
            for (long i = 2; i < value; i++)
            {
                if (MathProblemsLibrary.Divisors.IsDivisor(value, i))
                {
                    if (resultlist.IndexOf(i) < 0)
                    {
                        resultlist.Add(i);
                        value = value / i;
                        i = 2;
                    }
                }
            }
            resultlist.Add(value);
            return resultlist;
        }
    }
}