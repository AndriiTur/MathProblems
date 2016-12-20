using System;
using static MathsProblems.MathProblemsLibrary;

namespace MathsProblems
{
    internal class Problem25
    {
        internal static string Thousannd_digit_Fibonacci_number()
        {
            int digits = 0;
            int digits2 = 0;
            int digitsTemp = 0;
            int sum = 0;
            int index = 2;
            string fibonaccci_n = "1";
            string fibonaccci_n__1 = "1";
            string fibonaccci_n__2 = "1";

            while (fibonaccci_n.Length != 1000)
            {
                fibonaccci_n = "";
                for (int i = 1; i <= fibonaccci_n__1.Length; i++)
                {
                    if (fibonaccci_n__2.Length - i >= 0)
                    {
                        digits = Convert.ToInt32(fibonaccci_n__1[fibonaccci_n__1.Length - i].ToString());
                        digits2 = Convert.ToInt32(fibonaccci_n__2[fibonaccci_n__2.Length - i].ToString());
                        digitsTemp = digits + digits2 + sum;
                        if (digitsTemp >= 10)
                        {
                            sum = 1;
                            fibonaccci_n = (digitsTemp % 10).ToString() + fibonaccci_n;
                        }
                        else
                        {
                            sum = 0;
                            fibonaccci_n = digitsTemp.ToString() + fibonaccci_n;
                        }
                    }
                    else
                    {
                        if ((fibonaccci_n__2.Length - i < 0) && (fibonaccci_n__1.Length - i >= 0))
                        {
                            if (digitsTemp >= 10)
                            {
                                digits = Convert.ToInt32(fibonaccci_n__1[fibonaccci_n__1.Length - i].ToString());
                                fibonaccci_n = (digits + 1).ToString() + fibonaccci_n;
                                digitsTemp = digits + 1;
                            }
                            else
                            {
                                digits = Convert.ToInt32(fibonaccci_n__1[fibonaccci_n__1.Length - i].ToString());
                                fibonaccci_n = digits.ToString() + fibonaccci_n;
                                digitsTemp = digits;
                            }
                        }
                    }
                }
                if (digitsTemp >= 10)
                    fibonaccci_n = "1" + fibonaccci_n;
                sum = 0;
                fibonaccci_n__2 = fibonaccci_n__1;
                fibonaccci_n__1 = fibonaccci_n;
                index++;
                //MathsProblemsForm.Log(index.ToString() + "\t" + fibonaccci_n);
            }
            return index.ToString();
        }

    }
}