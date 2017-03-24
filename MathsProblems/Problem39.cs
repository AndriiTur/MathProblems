namespace MathsProblems
{
    internal class Problem39
    {
        public const int p = 1000;

        internal static string Integer_right_triangles()
        {
            int maxVal = 0;
            int perum = 0;
            for (int i = 3; i < p; i++)
            {
                int val = 0;
                for (int j = 1; j < p / 2; j++)
                {
                    for (int k = j; k < p / 2; k++)
                    {
                        for (int n = k; n < p / 2; n++)
                        {
                            if (j + k + n == i && Check_Pifagor(j, k, n))
                            {
                                val++;
                                MathsProblemsForm.Log(j.ToString() + " + " + k.ToString() + " + " + n.ToString() + " = " + i.ToString());
                                if (val > maxVal)
                                {
                                    perum = i;
                                    maxVal = val;
                                    MathsProblemsForm.Log(perum.ToString() + "      " + maxVal.ToString());
                                }
                            }
                        }
                    }
                }

            }
            return perum.ToString();
        }

        internal static bool Check_Pifagor(int a, int b,int gip)
        {
            if ((a * a + b * b) == gip * gip)
                return true;
            else return false;
        }
    }
}