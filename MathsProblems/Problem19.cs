using System.Linq;

namespace MathsProblems
{
    internal class Problem19
    {
        internal static int DaysOfMon(int mon,int year)
        {
            if ((mon == 1) || (mon == 3) || (mon == 5) || (mon == 7) || (mon == 8) || (mon == 10) || (mon == 12))
                return 31;
            else
            if (mon == 2)
            {
                if ((year % 4 == 0) && !(year % 400 == 0))
                   return 29; 
                else
                   return 28; 
            }
            else
                return 30;
        }

        internal static string Counting_Sundays()
        {
            var result = 0;
            var sundayDay = 6;
            for (int year = 1901; year < 2001; year++)
            {
                for (int mon = 1; mon <= 12; mon++)
                {
                    if (sundayDay == 1)
                        result++;
                    sundayDay = (sundayDay + 28) - DaysOfMon(mon, year);
                    if (sundayDay <= 0)
                        sundayDay = sundayDay + 7;

                    //sundayDay = sundayDay + DaysOfMon(mon, year);
                    //sundayDay = (sundayDay) % 7;
                }
            }
            return result.ToString();
        }
    }
}