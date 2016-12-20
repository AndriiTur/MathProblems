namespace MathsProblems
{

    internal class Problem6
    {
        private const int n = 100;
        internal static string Sum_square_difference()
        {
            int sumSqrt = 0;
            int sqrtSum = 0;
            int sum = 0;
            int result;
            for (int i = 1; i <= n; i++)
            {
                sumSqrt += i * i;
                sum += i;
            }

            sqrtSum = sum * sum;
            result = sqrtSum - sumSqrt;
            return result.ToString();
        }
    }

}