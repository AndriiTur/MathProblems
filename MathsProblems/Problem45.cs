using System;
using System.Collections.Generic;

namespace MathsProblems
{
    internal class Problem45
    {
        internal static string Triangular_pentagonal_and_hexagonal()
        {
            Int64 trian = 0;
            Int64 penta = 0;
            Int64 hexag = 0;
            Int64 tempj = 1;
            Int64 tempk = 1;
            int resultCount = 0;
            for (Int64 i = 285; trian < Int64.MaxValue / 2; i++)
            {
                trian = (i * (i + 1)) / 2;
                for (Int64 j = tempj; penta <= trian; j++)
                {
                    penta = (j * (3 * j - 1)) / 2;
                    if (trian == penta)
                    {
                        for (Int64 k = tempk; hexag <= trian; k++)
                        {
                            hexag = k * (2 * k - 1);
                            if (hexag == trian)
                            {
                                resultCount++;
                                MathsProblemsForm.Log(trian.ToString() + " " + i.ToString() + " " + j.ToString() + " " + k.ToString());
                                if (resultCount == 2)
                                {
                                    return trian.ToString();
                                }
                            }
                            tempk = k;
                        }
                    }
                    tempj = j;
                }
            }
            return "";
        }
    }
}