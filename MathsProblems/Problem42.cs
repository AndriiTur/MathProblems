using System;
using System.Collections.Generic;

namespace MathsProblems
{
    internal class Problem42
    {
        internal static string Coded_triangle_numbers()
        {
            char[] delimiterChars = { '"',',' };
            string text = System.IO.File.ReadAllText(@"D:\job\worlds.txt");
            string[] listWorlds = text.Split(delimiterChars);
            List<int> resList = new List<int> { };
            List<int> triangleNumbers = new List<int> { };
            int maxVal = 0;
            int result = 0;
            for (int i = 0; i < listWorlds.Length; i++)
            {
                int wordVal = 0;
                for (int j = 0; j < listWorlds[i].Length; j++)
                {
                    wordVal += (int)listWorlds[i][j] - 64;
                }
                if (wordVal > maxVal)
                    maxVal = wordVal;
                //MathsProblemsForm.Log(listWorlds[i].ToString() +"  =  "+ wordVal.ToString());
                resList.Add(wordVal);
            }
            for (int i = 1; i <= maxVal; i++)
            {
                triangleNumbers.Add(i * (i + 1) / 2);
            }
            for (int n = 0; n < resList.Count; n++)
            {
                if (triangleNumbers.IndexOf(resList[n]) >= 0)
                    result++;
            }
            return result.ToString();
        }
    }
}