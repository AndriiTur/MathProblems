using System;
using System.Collections.Generic;

namespace MathsProblems
{
    internal class Problem43
    {
        public const Int64 minVal = 1406357289;
        public const Int64 maxVal = 9876543210;

        internal static string Sub_string_divisibility()
        {
            List<Int64> valList = new List<Int64> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            Int64 res = 0;
            string strDigit = "";
            List<Int64> listPandigital = new List<Int64> { };
            listPandigital = Build_Pandigital_Digits(valList.Count,valList);
            for (int i = 0; i < listPandigital.Count; i++)
            { 
                strDigit = listPandigital[i].ToString();
                if (MathProblemsLibrary.OthertFuncktion.Check_Pandigital_products(strDigit, 10)
                && Check_property(strDigit))
                {
                    res += listPandigital[i];
                    MathsProblemsForm.Log(listPandigital[i].ToString());
                }
            }
            return res.ToString();
        }

        internal static bool Check_property(string cVal)
        {
            int[] valDivisor = new int[] { 17, 13, 11, 7, 5, 3, 2};
            string strDigit = "";
            int index = 0;
            for (int i = 7; i >= 1; i--)
            {
                strDigit = cVal[i].ToString() + cVal[i + 1].ToString() + cVal[i + 2].ToString();
                if (int.Parse(strDigit) % valDivisor[index] != 0)
                    return false;
                index++;
            }
            return true;
        }

        internal static List<Int64> Build_Pandigital_Digits(int rank, List<Int64> valList , string pandigitalStr = "")
        {
            List<Int64> resultList = new List<Int64> {};
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