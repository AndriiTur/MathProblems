using System.Linq;

namespace MathsProblems
{
    internal class Problem15
    {
        
             
        internal static string Lattice_paths()
        {
            long resultTemp2 = 1;
            long k = 2;
            long resultTemp1 = 1;
            long result = 1;
            var array = Enumerable.Range(21, 20).ToArray<int>();
            var array2 = Enumerable.Range(1, 20).ToArray<int>();
            for (int i = 0; i < array.Length ; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array[i] % array2[j] == 0)
                    {
                        array[i] = array[i] / array2[j];
                        array2[j] = 1;
                    }
                }

            }
            for (k = 0; k < array.Length; k++)
            {
                resultTemp1 = resultTemp1 * array[k];
                resultTemp2 = resultTemp2 * array2[k];
            }
            
            result = resultTemp1/resultTemp2;
            return result.ToString();
        }

    }
}