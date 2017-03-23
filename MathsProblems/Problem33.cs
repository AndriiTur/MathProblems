using System.Collections.Generic;

namespace MathsProblems
{
    internal class Problem33
    {
        internal static string Digit_cancelling_fractions()
        {
            List<int> digits = new List<int> { };
            int result = 0;
            int res = 0;
            int res2 = 0;
            int newNum = 0;
            int newDenum = 0;
            int prodnewNum = 1;
            int prodnewDenum = 1;
            for (int i = 10; i < 100; i++)
            {
                digits.Add(i);
            }
            for (int i = 0; i < digits.Count; i++)
            {
                for (int j = i + 1; j < digits.Count; j++) 
                {
                    if ((digits[j]%10 != 0 && digits[i] % 10 != 0) 
                        && (Check_numerator_and_denominator(digits[i], digits[j])))
                    {
                        string numStr = digits[i].ToString();
                        string denumStr = digits[j].ToString();
                        for (int k = 0; k < numStr.Length; k++)
                        {
                            if (numStr.IndexOf(denumStr[k]) >= 0)
                            {
                                newNum = int.Parse(numStr.Remove(numStr.IndexOf(denumStr[k]), 1));
                                newDenum = int.Parse(denumStr.Remove(denumStr.IndexOf(denumStr[k]), 1));
                            }
                        }
                        res = digits[j] / digits[i];
                        res2 = newDenum / newNum;
                        if ((digits[i] % newNum == 0 && digits[i] / newNum * newDenum == digits[j] && digits[j] / digits[i] == newDenum / newNum && digits[j] / digits[i] != 1 && newDenum / newNum != 1) ||
                                (res == res2 && digits[j] % digits[i] == 0 && newDenum % newNum == 0 ))
                        {
                            prodnewNum = prodnewNum * digits[i];
                            prodnewDenum = prodnewDenum * digits[j];
                            MathsProblemsForm.Log(digits[i].ToString() + " / " + digits[j].ToString() + " = " + res.ToString() +
                                    "      " + newNum.ToString() + " / " + newDenum.ToString() + " = " + res2.ToString());
                        }
                    }
                }
            }
            result = prodnewDenum/prodnewNum;
            return result.ToString();
        }

        internal static bool Check_numerator_and_denominator(int num,int denum)
        {
            string numStr = num.ToString();
            string denumStr = denum.ToString();
            for (int i = 0; i < numStr.Length; i++)
            {
                if (denumStr.IndexOf(numStr[i]) >= 0)
                    return true;
            }
            return false;
        }

        internal static void Change_Fration(int num, int index)
        {
            string numStr = num.ToString();
            for (int i = 0; i < numStr.Length; i++)
            {
                numStr.Remove(index,1);
                
            }
        }
    }
}