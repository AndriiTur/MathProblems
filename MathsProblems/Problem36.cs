namespace MathsProblems
{
    internal class Problem36
    {
        public const int maxVal = 1000000;

        internal static string Double_base_palindromes()
        {
            int result = 0;
            for (int i = 1; i < maxVal; i++)
            {
                if (Is_Digits_Palindrommes(i.ToString()) && Is_Digits_Palindrommes(Digit_To_Binary_Base(i)))
                {
                    MathsProblemsForm.Log(i.ToString() + "        " + Digit_To_Binary_Base(i).ToString());
                    result += i;
                }
            }
            return result.ToString();
        }

        internal static bool Is_Digits_Palindrommes(string digit)
        {
            int leng = 0;
            int j = 0;
            if (digit.Length % 2 == 0)
                leng = digit.Length / 2 - 1;
            else
                leng = digit.Length / 2;
            j = digit.Length - 1;

            for (int i = 0; i <= leng; i++)
            {
                if (digit[i] != digit[j])
                    return false;
                j--;
            }
            return true;
        }

        internal static string Digit_To_Binary_Base(int digitVal)
        {
            string result = "";
            while (digitVal >= 1)
            {
                if (digitVal % 2 == 0)
                    result = 0 + result;
                else
                    result = 1 + result;
                digitVal = digitVal / 2;
            }
            return result;  
        }
    }
}