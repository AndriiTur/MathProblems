using System;
using System.Collections.Generic;

namespace MathsProblems
{
    internal class Problem51
    {
        internal static string Prime_digit_replacements()
        {
            List<Int64> primes = MathProblemsLibrary.Primes.GetBelov(999999);
            List<string> primesStr = new List<string>();
            foreach (var prime in primes)
                primesStr.Add(prime.ToString());
            List<string> result = new List<string>();
            Dictionary<int, List<string>> listMask = CreateMaskList();
            List<string> checkMaskList = new List<string> {"0"};
            int i = 0;

            foreach (var primeStr in primesStr)
            {
                List<string> masks = CreateMask(primeStr, new List<string>());
                foreach (var mask in masks)
                {
                    if (checkMaskList.IndexOf(mask) == -1)
                    {
                        if (checkMaskList[0].Length < mask.Length)
                            checkMaskList.Clear();
                        checkMaskList.Add(mask);
                        result = BuildList(mask, primesStr, i, primeStr, result);
                        if (result.Count >= 8)
                        {
                            foreach (var val in result)
                                MathsProblemsForm.Log(val.ToString());
                            return result[0].ToString();
                        }
                    }
                }
                i++;
            }
            return "";
        }

        internal static string Prime_digit_replacements_old()
        {
            List<Int64> primes = MathProblemsLibrary.Primes.GetBelov(999999);
            List<string> primesStr = new List<string>();
            foreach (var prime in primes)
                primesStr.Add(prime.ToString());
            List<string> result = new List<string>();
            Dictionary<int, List<string>> listMask = CreateMaskList();
            List<string> checkMaskList = new List<string>();
            int i = 0;

            foreach (var primeStr in primesStr)
            {
                List<string> masks = listMask[primeStr.Length];
                foreach (var mask in masks)
                {
                    result = BuildList(mask, primesStr, i, primeStr, result);
                    if (result.Count >= 8)
                    {
                        foreach (var val in result)
                            MathsProblemsForm.Log(val.ToString());
                        return result[0].ToString();
                    }
                }
                i++;
            }
            return "";
        }

        internal static List<string> BuildList(string mask, List<string> primesStr, int index, 
            string valueOfMask, List<string> resultParam)
        {
            var maskLength = mask.Length;
            List<string> result = resultParam;
            result.Clear();
            for (int primeIndex = index; primeIndex < primesStr.Count; primeIndex++)
            {
                string prim = primesStr[primeIndex];

                if (mask[0] != '?')
                {
                    if (prim[0] < valueOfMask[0])
                        continue;
                    if (prim[0] > valueOfMask[0])
                        break;
                }
                if (maskLength < prim.Length)
                {
                    break;
                }
                if (CheckMask(mask, prim))
                    result.Add(primesStr[primeIndex]);
            }
            //if (result.Count > primeMax.Count)
            //{
            //    primeMax = result;
            //}
            return result;
        }

        internal static List<string> BuildListOld(string mask, List<string> primesStr, int index,
            string valueOfMask, List<string> resultParam)
        {
            var maskLength = mask.Length;
            List<string> result = resultParam;
            result.Clear();
            for (int primeIndex = index; primeIndex < primesStr.Count; primeIndex++)
            {
                string prim = primesStr[primeIndex];

                if (mask[0] == '-')
                {
                    if (prim[0] < valueOfMask[0])
                        continue;
                    if (prim[0] > valueOfMask[0])
                        break;
                }
                if (maskLength < prim.Length)
                {
                    break;
                }
                if (CheckMaskOld(mask, prim, valueOfMask))
                    result.Add(primesStr[primeIndex]);
            }
            //if (result.Count > primeMax.Count)
            //{
            //    primeMax = result;
            //}
            return result;
        }

        internal static Dictionary<int, List<string>> CreateMaskList()
        {
            string maskval = "";
            List<string> resVal = new List<string>();
            Dictionary<int, List<string>> result = new Dictionary<int, List<string>>();
            for (int i = 1; i <= 6; i++)
            {
                maskval += "-";
                resVal = CreateMask(maskval, resVal);
                result.Add(i, resVal);
            }
            return result;
        }

        internal static List<string> CreateMask(string interVal, List<string> resList)
        {
            char[] valArray = interVal.ToCharArray();
            string res = "";
            char tempCh = ' ';
            List<string> temp = new List<string>();
            List<string> result = new List<string>();
            int count = 0;
            for (int k = valArray.Length - 1; k >= 0; k--)
            {
                if (valArray[k] == '?')
                    count++;
             }
            if (count == valArray.Length - 1)
            {
                return temp;
            }

            for (int i = valArray.Length - 1; i >= 0; i--)
            {
                if (valArray[i] != '?')
                {
                    tempCh = valArray[i];
                    valArray[i] = '?';
                    res = "";
                    for (int j = valArray.Length - 1; j >= 0; j--)
                    {
                        res = valArray[j] + res;
                    }
                    temp.Add(res);
                    temp.AddRange(CreateMask(res, temp));
                    valArray[i] = tempCh;
                }
            }
            foreach (var val in temp)
            {
                if (result.IndexOf(val) == -1)
                    result.Add(val);
            }
            return result;
        }

        internal static bool CheckMask(string mask, string prime)
        {
            char temp = (char)0;
            for (int i = 0; i < mask.Length; i++)
            {
                if (mask[i] != '?' && mask[i] != prime[i])
                {
                    return false;
                }
                if (mask[i] == '?')
                {
                    if (temp == (char)0)
                        temp = prime[i];
                    else
                    if (prime[i] != temp)
                        return false;
                }
            }
            return true;
        }

        internal static bool CheckMaskOld(string mask, string prime, string valueOfMask)
        {
            int ind = mask.IndexOf('?');
            char temp = (char)0;
            for (int i = 0; i < mask.Length; i++)
            {
                if ((mask[i] == '-') && (prime[i] != valueOfMask[i]))
                {
                    return false;
                }
                if (mask[i] == '?')
                {
                    if (temp == (char)0)
                        temp = prime[i];
                    else
                    if (prime[i] != temp)
                        return false;
                }
            }
            return true;
        }
    }
}