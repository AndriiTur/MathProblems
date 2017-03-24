namespace MathsProblems
{
    internal class Problem38
    {
        internal static string Pandigital_multiples()
        {
            string resDigit = "";
            int resDig;
            int mnognuk;
            int maxVal = 0;
            for (int i = 1; i < 10000; i++)
            {
                mnognuk = 1;
                resDigit = "";
                while (resDigit.Length < 9)
                {
                    resDig = i * mnognuk;
                    resDigit += resDig.ToString();
                    mnognuk++;
                }
                if (resDigit.Length == 9 && Check_Pandigital_products(resDigit) && int.Parse(resDigit) > maxVal)
                {
                    maxVal = int.Parse(resDigit);
                    MathsProblemsForm.Log(resDigit);
                }
            }
            return maxVal.ToString();
        }

        internal static bool Check_Pandigital_products(string valStr)
        {
            string checkStr = "123456789";
            for (int i = 0; i < checkStr.Length; i++)
            {
                if (valStr.IndexOf(checkStr[i]) < 0) 
                    return false;

            }
            return true;

        }
    }
}