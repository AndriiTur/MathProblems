using System.Collections.Generic;
using static MathsProblems.MathProblemsLibrary;

namespace MathsProblems
{

    internal class Problem12
    {
        internal static string Highly_divisible_triangular_number()
        {

            long value = 1;
            long temp = 2;
            var resultList = new List<long>();
            while (resultList.Count <= 500)
            {
                resultList = Divisors.GetList(value);
                value = value + temp;
                temp++;
            }
            var result = value - (temp - 1);
            return result.ToString();
        }
    }


}