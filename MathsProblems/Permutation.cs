using System;
using System.Collections.Generic;
using static MathsProblems.MathProblemsLibrary;

namespace MathsProblems
{
    public class Permutation
    {
        public delegate bool DoCombination(List<int> combination);

        public static string NumberOfPermutation(List<int> pool)
        {
            string result = "";
            result = LargeDigitsDestroyer.Faktorial(pool.Count);
            return result;
        }

        public static int FindCombinationIndex(List<int> pool,List<int> combin)
        {
            int combinationCount = 0;
            DoCombination doCombination = (combination) =>
            {
                combinationCount++;
                if (combination.Equals(combin))
                    return true;
                return false;
            };
            Permutation.Enumerate(pool, doCombination);
            return combinationCount;
        }

        public static List<List<int>> GetAllCobminations(List<int> pool)
        {
            var resultCombinationList = new List<List<int>>();
            DoCombination doCombination = (combination) =>
            {
                resultCombinationList.Add(combination);
                return false;
            };
            Permutation.Enumerate(pool, doCombination);
            return resultCombinationList;
        }

        public static List<int> FindCombination(List<int> pool,int maxCount)
        {
            List<int> resultCombination = new List<int>();
            var combinationCount = 0;
            Permutation.DoCombination doCombination = (combination) =>
            {
                combinationCount++;
                if (combinationCount == maxCount)
                {
                    resultCombination = combination;
                    return true;
                }
                return false;
            };

            Permutation.Enumerate(pool, doCombination);
            return resultCombination;
        }

        public static bool Enumerate(List<int> pool, DoCombination doCombination)
        {
            List<int> combination = new List<int>();
            for (int i = 0; i < pool.Count; i++)
                combination.Add(-1);
            return EnumerationRecursive(pool, combination, 0, doCombination);
        }

        private static bool EnumerationRecursive(List<int> pool, List<int> combination, int index, DoCombination doCombination)
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

                if (doCombination(combination))
                    return true;

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
                if (EnumerationRecursive(pool, combination, index + 1 , doCombination))
                    return true;
                pool[i] = temp;
                combination[index] = -1;
            }

            return false;
        }
    }
}