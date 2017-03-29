using System.Collections.Generic;

namespace MathsProblems
{
    internal class Problem44
    {
        internal static string Pentagon_numbers()
        {
            int pent = 0;
            List<int> pentList = new List<int> { };
            int minVal = 10000000;
            int didifference = 0;
            int sum = 0;
            for (int i = 1; i < 10000; i++)
            {
                pent = i * (3 * i - 1) / 2;
                if (pent > 0)
                {
                    pentList.Add(pent);
                }
            }
            for (int j = 0; j < pentList.Count; j++)
            {
                for (int k = j + 1; k < pentList.Count; k++)
                {
                    sum = pentList[k] + pentList[j];
                    didifference = pentList[k] - pentList[j];
                    if (Is_Pentagon(didifference, pentList) && Is_Pentagon(sum, pentList))
                    {
                        if (didifference < minVal)
                        {
                            MathsProblemsForm.Log(pentList[k].ToString() + "  " + pentList[j].ToString() + "    " + didifference.ToString());
                            minVal = didifference;
                            return minVal.ToString();
                        }
                    }
                }
            }
            return minVal.ToString();
        }

        internal static bool Is_Pentagon(int val, List<int> pentList)
        {
            if (pentList.IndexOf(val) < 0)
                return false;
            else
                return true;
        }
    }
}