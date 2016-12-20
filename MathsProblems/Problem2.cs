using System;

namespace MathsProblems
{


    internal class Problem2
    {
        internal static string Even_Fibonacci_numbers()
        {
            int k = 0;
            int fib;
            for (int i = 1; i < 34; i++)
            {
                fib = Fibonachi(i);
                if (fib % 2 == 0)
                    k += fib;
            }
            return k.ToString();
        }


        private static int Fibonachi(int n)
        {
            if (n <= 0)
                throw new IndexOutOfRangeException();
            if (n == 1)
                return 1;
            if (n == 2)
                return 1;

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
    }

}