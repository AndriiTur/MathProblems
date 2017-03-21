namespace MathsProblems
{
    internal class Problem28
    {
        public const int stepMaxValue = 500; 
        internal static string Number_spiral_diagonals()
        {
            int step = 2;
            int index = 0;
            int result = 1;
            int stepValue = 1;
            for (int i = 3; stepValue <= stepMaxValue ; i = i + step)
            {
                if (index == 3)
                {
                    stepValue++;
                    result += i;
                    index = 0;
                    step += 2;
                }
                else
                {
                    result += i;
                    index++;
                }
                //MathsProblemsForm.Log(i.ToString() +"\t"+ result.ToString());
            }
            return result.ToString(); 
        }
    }
}