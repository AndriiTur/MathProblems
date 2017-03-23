namespace MathsProblems
{
    internal class Problem34
    {
        public const int maxVal = 50000;

        internal static string Digit_factorials()
        {
            
            int res = 0;
            int result = 0;
            string digit;
            for (int i = 3; i < maxVal; i++)
            {
                res = 0;
                digit = i.ToString();
                for (int j = 0; j < digit.Length; j++)
                {
                    res += int.Parse(MathProblemsLibrary.LargeDigitsDestroyer.Faktorial(int.Parse(digit[j].ToString())));
                    
                }
                if (res == i)
                {
                    result += res;
                    MathsProblemsForm.Log(digit + "      " + res.ToString());
                }
            }
            return result.ToString();
        }
    }
}