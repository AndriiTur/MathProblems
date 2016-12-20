using System;
using System.Collections.Generic;
using System.Linq;

namespace MathsProblems
{
    internal class Problem24
    {
        public const int maxCount = 1000000;
        public static List<int> resultCombination = null;
        public static List<int> pool = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        
        internal static string Lexicographic_permutations()
        {
            string strResult = "";
            resultCombination = Permutation.FindCombination(pool, maxCount);
            foreach (var str in resultCombination)
                strResult += str.ToString();
            return strResult;
        }
    }
}