namespace MathsProblems
{

    internal class Problem9
    {
        private const int value = 1000;

        internal static string Special_Pythagorean_triplet()
        {


            for (var i = 1; i < value; i++)
            {
                for (var j = i + 1; j < value; j++)
                {
                    for (var k = j + 1; k < value; k++)
                    {
                        if (i + j + k == value)
                        {
                            if (Sqr(i) + Sqr(j) == Sqr(k))
                            {
                                int result = i * j * k;
                                return result.ToString();
                            }
                        }
                    }
                }
            }
            return "-1";
        }

        internal static int Sqr(int index)
        {
            return index * index;
        }

    }


}