namespace MathsProblems
{
    internal class Problem17
    {
       
        internal static string Number_Letter_Counts()
        {
            var strIn = new string[] { "","one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var strIn12 = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var strIn10 = new string[] { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            var strIn100 = "hundred";
            var strAnd = "and";
            var strT = "onethousand";
            var strRes = new string[1001] ;
            int j = 0,i = 0;
            int n = 1,temp = 1;
            int count = 0 ,index = 0;
            for (i = 0; i < strRes.Length; i++)
            {
                if ((i > 0) && (i < 10))
                    strRes[i] = strIn[i];
                if ((i > 9) && (i < 20))
                    strRes[i] = strIn12[i - 10];
                if ((i > 19) && (i < 100))
                {
                    if (index >= 10)
                    { index = 0; j++; }
                    strRes[i] = strIn10[j] + strIn[index];
                    index++;
                }
                if ((i >= 100) && (i < 1000))
                {
                    if (i % 100 == 0)
                    {
                        strRes[i] = strIn[i / 100] + strIn100;
                    }
                    else
                    {
                        if (temp >= 100)
                        { temp = 1; n++; }
                        strRes[i] = strIn[n] + strIn100 + strAnd + strRes[temp];
                        temp++;
                    }
                }
                if (i == 1000)
                    strRes[i] = strT;
            }
            for (i = 1; i < strRes.Length; i++)
                for (j = 0; j < strRes[i].Length; j++)
                    count++;
            return count.ToString();
        }
    }
}