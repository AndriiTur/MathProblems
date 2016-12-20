using System.Collections.Generic;
using static MathsProblems.MathProblemsLibrary;

namespace MathsProblems
{
    internal class Problem23
    {
        private const int value = 28123;

        internal static string Non_abundant_sums()
        {
            var myList = new Dictionary<int,int>();
            long result = 0;
            myList = Abundant_Digits.Abundant_Summ_List(Abundant_Digits. Abundant_List(value));
            for (int i = 0; i <= value; i++)
            {
                if (!myList.ContainsKey(i))
                    result += i;
            }
            return result.ToString();
        }
    }
}