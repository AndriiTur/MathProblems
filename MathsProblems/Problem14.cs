namespace MathsProblems
{

    internal class Problem14
    {
        internal static string Longest_Collatz_sequence()
        {
            long count = 0;
            var value = 1000000;
            long longest = 0;
            long temp = 0;
            for (int i = value; i > 0; i--)
            {
                count = Collatz_sequence(i);
                if (longest < count)
                {
                    longest = count;
                    temp = i;
                }
            }
            return temp.ToString();
        }

        internal static long Collatz_sequence(long value)
        {
            long count = 0;

            while (value != 1)
            {
                if (value % 2 == 0)
                {
                    value = value / 2;
                    count++;
                }
                else
                {
                    value = 3 * value + 1;
                    count++;
                }
            }
            return count;
        }
    }


}