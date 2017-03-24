using System.Collections.Generic;

namespace MathsProblems
{
    internal class Problem32
    {
        internal static string Pandigital_products()
        {
            return Pandigital_products_Sum().ToString();
        }

        internal static int Pandigital_products_Sum()
        {
            List<int> digits = new List<int> { };
            List<int> digits2 = new List<int> { };
            List<int> reslist = new List<int> { };
            int resDigit = 0;
            int result = 0;
            string resStr = "";
            for (int i = 2; i < 100; i++)
            {
                if(i%10 != 0)
                    digits.Add(i);
            }
            for (int i = 101; i < 10000; i++)
            {
                if ((i % 100 > 9) && (i %10 != 0) && (i % 1000 > 99))
                    digits2.Add(i);
            }
            for (int j = 0; j < digits.Count; j++)
            {
                for (int k = 0; k < digits2.Count; k++)
                {
                    resDigit = digits[j] * digits2[k];
                    resStr = digits[j].ToString() + digits2[k].ToString() + resDigit.ToString();
                    if ((resDigit.ToString().Length < 5) && (resDigit.ToString().Length > 3) 
                        && (Check_Pandigital_products(resStr)) && (reslist.IndexOf(resDigit) < 0))
                    {
                        reslist.Add(resDigit);
                        result += resDigit;
                    }
                }
            }
            return result;
        }

        internal static bool Check_Pandigital_products(string valStr)
        {
            string checkStr = "123456789";
            for (int i = 0; i < checkStr.Length; i++)
            {
                if (valStr.IndexOf(checkStr[i]) < 0)
                    return false;
                
            }
            return true;

        }


    }
}