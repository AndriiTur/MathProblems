namespace MathsProblems
{
    internal class Problem4
    {
        private const int n = 999;
        private const int min = 100;

        internal static string Largest_palindrome_product()
        {
            int val = 0;
            int maxPolinom = 0;
            for (int i = n; i >= min; i--)
            {
                for (int j = i; j >= min; j--)
                {
                    val = i * j;
                    if (IsPolinom(val))
                    {
                        if (maxPolinom < val)
                        {
                            maxPolinom = val;
                        }
                    }
                }  
            }
            return maxPolinom.ToString();
        }

        internal static bool IsPolinom(int Value)
        {
            var str = Value.ToString();
            for (int k = 0; k < str.Length / 2; k++)
            {
                if (str[k] != str[(str.Length - 1) - k])
                {
                    return false;


                }
            }
            return true;
        }

    }

}