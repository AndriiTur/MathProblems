using static MathsProblems.MathProblemsLibrary;

namespace MathsProblems
{
    internal class Problem5
    {
        private const int divis = 20;

        internal static string Smallest_multiple()
        {
            bool number = true;
            long val = divis;
            while (number)
            {
                number = false;
                for (long i = 1; i <= divis; i++)
                {
                    if (Divisors.IsDivisor(val, i))
                    {
                        if (i == divis)
                            number = false;
                    }
                    else
                    {
                        val = val + divis;
                        number = true;
                        i = 1;
                        break;
                    }
                }
            }
            return val.ToString();
        }
    }

}