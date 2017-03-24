using System;
using System.Text;

namespace MathsProblems
{
    internal class Problem40
    {
        internal static string Champernownes_constant()
        {

            StringBuilder stbuilder = new StringBuilder();
            string strVal = "";
            int i = 0;
            int result = 1;
            while (stbuilder.Length <= 1000100)
            {
                //strVal += i.ToString();
                stbuilder.Append(i.ToString());
                i++;
            }
            strVal = stbuilder.ToString();
            //result = result * int.Parse(strVal[0].ToString());
            for (int j = 1; j < strVal.Length; j = j * 10)
            {
                result = result * int.Parse(strVal[j].ToString());
            }
            return result.ToString();
        }
    }
}