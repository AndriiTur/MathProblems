using System;
using System.Collections.Generic;
using static MathsProblems.MathProblemsLibrary;

namespace MathsProblems
{
    internal class Problem21
    {
        public const int value = 10000;
        internal static string Amicable_numbers()
        {
            var resultlist = new List<Int64>();
            var resultlist2 = new List<Int64>();
            int ammDigits = 0;
         
            int i = 0;
            int result = 0;
            for (i = value; i > 0; i--)
            {
                ammDigits = OthertFuncktion.Amicable_numbers(i);
                if ((ammDigits != 0) && (ammDigits != i))
                        result += i;
            }
            return result.ToString();
        }
    }
}