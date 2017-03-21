using System.Collections.Generic;

namespace MathsProblems
{
    internal class Problem31
    {
        public const int valSum = 200;
        internal static string Coin_sums()
        {
           return (Coin_sums(valSum, valSum).ToString());
        }
        internal static int  Coin_sums(int val, int maxListVal)
        {
            int resCount = 0;
            List<int> listVal = new List<int> { 200, 100, 50, 20, 10, 5, 2, 1 };
            if (val == 0)
            {
                return 1;
            }
            else
            {
                for (int i = 0; i < listVal.Count; i++)
                {
                    if ((listVal[i] <= maxListVal) && (listVal[i] <= val))
                    {
                        resCount += Coin_sums(val - listVal[i], listVal[i]);
                    }
                }
                return resCount;
            }
            
        }
    }
}