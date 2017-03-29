using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MathsProblems
{
    class MathProblemsLibrary
    {

        internal class Primes
        {
            internal static List<Int64> GetBelov(Int64 value)
            {
                var resultList = new List<Int64>();
                for (long i = 2; i <= value; i++)
                {
                    if (!HasMultiplier(i, resultList))
                        resultList.Add(i);
                }
                return resultList;
            }

            internal static bool HasMultiplier(Int64 value, List<Int64> multipliers)
            {
                var sqrt = Math.Sqrt(value);
                foreach (var multiplayer in multipliers)
                {
                    if (value % multiplayer == 0)
                        return true;
                    if (multiplayer > sqrt)
                        return false;
                }
                return false;
            }
        }


        internal class Divisors
        {
            internal static int SummDivisor(int value)
            {
                var resultlist = new List<Int64>();
                int summDivivsors = 0;
                resultlist = GetList(value, false);
                foreach (int node in resultlist)
                    summDivivsors += node;

                return summDivivsors;
            }


            internal static List<Int64> GetList(Int64 value, bool addLastValue = true)
            {
                var resultList = new List<Int64>();
                Int64 limit = Convert.ToInt64(Math.Sqrt(value));
                for (long i = 1; i <= limit; i++)
                {
                    if (IsDivisor(value, i))
                    {
                        if (resultList.IndexOf(i) == -1)
                            if (addLastValue || i != value)
                                resultList.Add(i);
                        if (resultList.IndexOf(value / i) == -1)
                            if (addLastValue || (value / i) != value)
                                resultList.Add(value / i);
                    }
                }
                return resultList;
            }

            internal static List<Int64> GetPrimeList(Int64 value)
            {
                var resultlist = new List<Int64>();
                for (long i = 2; i < value; i++)
                {
                    if (IsDivisor(value, i))
                    {
                        if (!Primes.HasMultiplier(i, resultlist))
                        {
                            resultlist.Add(i);
                            value = value / i;
                            i = 2;
                        }
                    }
                }
                if (!Primes.HasMultiplier(value, resultlist))
                    resultlist.Add(value);
                return resultlist;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static bool IsDivisor(Int64 value, Int64 divisor)
            {
                if (value % divisor == 0)
                    return true;
                else
                    return false;
            }
        }
        internal class LargeDigitsDestroyer
        {
            internal static string Degree_Numbers(int value, int degree)
            {
                int digits = 0;
                int digitsTemp = 0;
                int sum = 0;
                string strTemp = "1";
                string strResult = "";

                for (int j = 0; j < degree; j++)
                {
                    for (int i = strTemp.Length - 1; i >= 0; i--)
                    {
                        digits = Convert.ToInt32(strTemp[i].ToString());
                        digitsTemp = digits * value + sum;
                        if (digitsTemp >= 10)
                        {
                            digits = digitsTemp % 10;
                            sum = (digitsTemp - (digitsTemp % 10)) / 10;
                            strResult = digits.ToString() + strResult;
                        }
                        else
                        {
                            sum = 0;
                            strResult = digitsTemp.ToString() + strResult;
                        }
                    }
                    if (digitsTemp >= 10)
                    {
                        sum = (digitsTemp - digits) / 10;
                        strResult = sum + strResult;
                    }
                    sum = 0;
                    strTemp = strResult;
                    strResult = "";
                }
                return strTemp;
            }

            internal static string Faktorial(int Faktorialvalue)
            {
                int digits = 0;
                int digitsTemp = 0;
                int sum = 0;
                string strTemp = "1";
                string strResult = "";

                for (int j = 2; j <= Faktorialvalue; j++)
                {
                    for (int i = strTemp.Length - 1; i >= 0; i--)
                    {
                        digits = Convert.ToInt32(strTemp[i].ToString());
                        digitsTemp = digits * j + sum;
                        if (digitsTemp >= 10)
                        {
                            digits = digitsTemp % 10;
                            sum = (digitsTemp - (digitsTemp % 10)) / 10;
                            strResult = digits.ToString() + strResult;
                        }
                        else
                        {
                            sum = 0;
                            strResult = digitsTemp.ToString() + strResult;
                        }
                    }
                    if (digitsTemp >= 10)
                    {
                        sum = (digitsTemp - digits) / 10;
                        strResult = sum + strResult;
                    }
                    sum = 0;
                    strTemp = strResult;
                    strResult = "";
                }
                return strTemp;
            }

            internal static string Fibonnacci(int fibonaccivalue)
            {
                int digits = 0;
                int digits2 = 0;
                int digitsTemp = 0;
                int sum = 0;
                string fibonaccci_n = "1";
                string fibonaccci_n__1 = "1";
                string fibonaccci_n__2 = "1";
                
                for (int j = 2; j < fibonaccivalue; j++)
                {
                    fibonaccci_n = "";
                    for (int i = 1 ; i <= fibonaccci_n__1.Length; i++)
                    {
                        if (fibonaccci_n__2.Length - i >= 0)
                        {
                            digits = Convert.ToInt32(fibonaccci_n__1[fibonaccci_n__1.Length - i].ToString());
                            digits2 = Convert.ToInt32(fibonaccci_n__2[fibonaccci_n__2.Length - i].ToString());
                            digitsTemp = digits + digits2 + sum;
                            if (digitsTemp >= 10)
                            {
                                sum = 1;
                                fibonaccci_n = (digitsTemp % 10).ToString() + fibonaccci_n;
                            }
                            else
                            {
                                sum = 0;
                                fibonaccci_n = digitsTemp.ToString() + fibonaccci_n;
                            }
                        }
                        else
                        {
                            if ((fibonaccci_n__2.Length - i < 0) && (fibonaccci_n__1.Length -i >=0))
                            {
                                if (digitsTemp >= 10)
                                {
                                    digits = Convert.ToInt32(fibonaccci_n__1[fibonaccci_n__1.Length - i].ToString());
                                    fibonaccci_n = (digits + 1).ToString() + fibonaccci_n;
                                    digitsTemp = digits + 1;
                                }
                                else
                                {
                                    digits = Convert.ToInt32(fibonaccci_n__1[fibonaccci_n__1.Length - i].ToString());
                                    fibonaccci_n = digits.ToString() + fibonaccci_n;
                                    digitsTemp = digits;
                                }
                            }
                        }
                    }
                    if (digitsTemp >= 10)
                        fibonaccci_n = "1" + fibonaccci_n;
                    sum = 0;
                    fibonaccci_n__2 = fibonaccci_n__1;
                    fibonaccci_n__1 = fibonaccci_n;
                }
                return fibonaccci_n;
            }

            internal static string Numbers_Summ(int value)
            {
                int digits = 0;
                int digitsTemp = 0;
                int sum = 0;
                string strTemp = "1";
                string strResult = "";

                for (int j = 0; j < value; j++)
                {
                    for (int i = strTemp.Length - 1; i >= 0; i--)
                    {
                        digits = Convert.ToInt32(strTemp[i].ToString());
                        digitsTemp = digits + value + sum;
                        if (digitsTemp >= 10)
                        {
                            digits = digitsTemp % 10;
                            sum = (digitsTemp - (digitsTemp % 10)) / 10;
                            strResult = digits.ToString() + strResult;
                        }
                        else
                        {
                            sum = 0;
                            strResult = digitsTemp.ToString() + strResult;
                        }
                    }
                    if (digitsTemp >= 10)
                    {
                        sum = (digitsTemp - digits) / 10;
                        strResult = sum + strResult;
                    }
                    sum = 0;
                    strTemp = strResult;
                    MathsProblemsForm.Log(strResult);
                    strResult = "";
                }
                return strTemp;
            }

            internal static string DivisionOfNatural(int digit,int divider,int length = 0)
            {
                List<int> divList = new List<int>();
                string strDigit = "0,";
                bool index = true;
                int tempDigit = 1;
                
                while (index) 
                {
                    divList.Add(digit);
                    if (digit % divider == 0)
                    {
                        strDigit += (digit / divider).ToString();
                        index = false;
                        break;
                    }
                    if (digit / divider < 1)
                    {
                        digit = digit * 10;
                        strDigit += "0";
                        index = true;
                    }
                    else
                    {
                        
                        strDigit += (digit / divider).ToString();
                        tempDigit = digit % divider;
                        digit = tempDigit * 10;
                        index = true;
                    }
                    if (divList.IndexOf(digit) != -1)
                    {
                        if (int.Parse(strDigit[strDigit.Length - 1].ToString()) == 0)
                            strDigit = strDigit.Remove(strDigit.Length - 1, 1);
                        if ((length != 0) && (strDigit.Length - 2 >= length))
                        {
                            strDigit = strDigit.Remove(length + 2, strDigit.Length - 2 - length);
                            index = false;
                            break;
                        }
                        else
                        {
                            if (length == 0)
                            {
                                strDigit = strDigit.Insert(divList.IndexOf(digit) + 2, "(");
                                strDigit += ")";
                                index = false;
                            }
                        }
                    }
                }
            return strDigit;
            }
        }
        
        internal class Abundant_Digits
        {
                internal static bool IsAbundant_Digit(int value)
            {
                if (Divisors.SummDivisor(value) > value)
                    return true;
                else
                    return false;
            }

            internal static Dictionary<int,int> Abundant_List(int value)
            {
                var myList = new Dictionary<int,int>();
                for (int i = 0; i <= value; i++)
                {
                        if (IsAbundant_Digit(i) == true)
                             myList.Add(i,0);
                }
                return myList;
            }

            internal static Dictionary<int,int> Abundant_Summ_List(Dictionary<int,int> myList)
            {
                var resList = new Dictionary<int,int>();
                foreach (var val in myList)
                {
                    foreach (var value in myList)
                    {
                        if (!resList.ContainsKey(val.Key + value.Key))
                        resList.Add(val.Key + value.Key, 0);
                    }
                }
                return resList;
            }
        }

        internal class Permutations
        {
            public static int combinationCount;
            public static string resultCombination;
            public const int maxCount = 1000000;
           
            internal static bool Lexicographic(List<int> pool, List<int> combination, int index)
            {
                int temp = 0;
                if (pool.Count - 1 == index)
                {
                    temp = -1;
                    for (int i = 0; i < pool.Count; i++)
                        if (pool[i] != -1)
                        {
                            temp = pool[i];
                            break;
                        }
                    if (temp == -1)
                        throw new Exception();

                    combination[index] = temp;
                    combinationCount++;
                    if (combinationCount == maxCount)
                    {
                        resultCombination = combination.ToString();
                        return true;
                    }
                    combination[index] = -1;
                    return false;
                }

                for (int i = 0; i < pool.Count; i++)
                {
                    temp = pool[i];
                    if (temp == -1)
                        continue;

                    combination[index] = temp;
                    pool[i] = -1;
                    if (Lexicographic(pool, combination, index + 1))
                        return true;
                    pool[i] = temp;
                    combination[index] = -1;
                }
                return false;
            }
        }

        internal class OthertFuncktion
        {
            internal static int Amicable_numbers(int value)
            {
                int ammDigits = 0;
                int temp2 = 0;
                ammDigits = Divisors.SummDivisor(value);
                temp2 = Divisors.SummDivisor(ammDigits);
                if (temp2 == value)
                    return ammDigits;
                else return 0;
            }

            internal static string Digit_To_Binary_Base(int digitVal)
            {
                string result = "";
                while (digitVal >= 1)
                {
                    if (digitVal % 2 == 0)
                        result = 0 + result;
                    else
                        result = 1 + result;
                    digitVal = digitVal / 2;
                }
                return result;
            }

            internal static bool Check_Pandigital_products(string valStr,int rank = 9)
            {
                string checkStr = "1234567890";
                for (int i = 0; i < rank; i++)
                {
                    if (valStr.IndexOf(checkStr[i]) < 0)
                        return false;
                }
                return true;
            }

            internal static List<Int64> Build_Pandigital_Digits(int rank, List<Int64> valList, string pandigitalStr = "")
            {
                List<Int64> resultList = new List<Int64> { };
                Int64 digit = 0;
                if (rank == 0)
                {
                    resultList.Add(Int64.Parse(pandigitalStr));
                    return resultList;
                }
                for (int i = 0; i < valList.Count; i++)
                {
                    pandigitalStr += valList[i].ToString();
                    digit = valList[i];
                    valList.Remove(digit);
                    //if (Build_Pandigital_Digits(rank - 1, valList, pandigitalStr).Count != 0)
                    resultList.AddRange(Build_Pandigital_Digits(rank - 1, valList, pandigitalStr));
                    if (valList.Count == 0)
                        valList.Add(digit);
                    else
                        valList.Insert(i, digit);
                    pandigitalStr = pandigitalStr.Remove(pandigitalStr.Length - 1);
                }
                return resultList;
            }
        }
    }
}
