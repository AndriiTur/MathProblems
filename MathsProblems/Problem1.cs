namespace MathsProblems
{


    internal class Problem1
    {
        private const int n = 1000;

        internal static string Multiples_of_3_and_5()
        {
            int k = 0;
            for (int i = 1; i < n; i++)
            {
                if (((i % 3) == 0) || ((i % 5) == 0))

                    k += i;
            }
            return k.ToString();

        }
    }

}