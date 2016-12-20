using System;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MyLibrary;

namespace MathsProblems
{
    internal class Problem22
    {
        internal static string Names_scores()
        {
            string InputFileStr = System.IO.File.ReadAllText(@"D:\job\projects\MathsProblems\p022_names.txt");
            int[] resultArray = new int[] { };
            string[] InputArray = new string[] { };
            string[] ReadyInputArr = new string[] { };
            string delimetr = ",";
            char delim = '"';
            string stringTemp = "";
            int digits = 0;
            int k = 0;
            int nameLength = 0;
            long result = 0;
            InputArray = MyString.Split(InputFileStr, delimetr);
            foreach (string i in InputArray)
            {
                stringTemp = MyString.DelFromString(i, delim);
                ReadyInputArr = MyString.AddArray(ReadyInputArr, stringTemp);
            }
            MyArray<string>.ArraySort(ReadyInputArr, MyArraySortDirection.LowToHight);
            foreach (string name in ReadyInputArr)
            {
                nameLength = 0; k++;
                foreach (char j in name)
                {
                    digits = GetValueInt(j);
                    nameLength += digits;
                    MyArray<int>.AddArrayInt(resultArray, nameLength, resultArray.Length);
                }
            }
            foreach (int ind in resultArray)
            {
                k++;
                result += ind * k;
            }
            return result.ToString();
        }

        internal static int GetValueInt(char val)
        {
            int a = val;
            string charval = a.ToString();
            int temp = Convert.ToInt32(charval) - 64;
            return temp;
        }
    }
}