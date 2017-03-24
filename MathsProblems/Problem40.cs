using System;

namespace MathsProblems
{
    internal class Problem40
    {
        internal static string Champernownes_constant()
        {
            string strVal = "0";
            int i = 1;
            int result = 1;
            while (strVal.Length <= 1000100)
            {
                strVal += i.ToString();
                i++;
            }
            //result = result * int.Parse(strVal[0].ToString());
            for (int j = 1; j < strVal.Length; j = j * 10)
            {
                result = result * int.Parse(strVal[j].ToString());
            }
            return result.ToString();
        }
    }
}