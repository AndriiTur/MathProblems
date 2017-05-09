using System.Collections.Generic;

namespace MathsProblems
{
    internal class Problem54
    {
        internal static string Poker_hands()
        {
            string line;
            List<string> playerOne = new List<string>();
            List<string> playerTwo = new List<string>();

            System.IO.StreamReader file =
                new System.IO.StreamReader(@"D:\job\projects\MathsProblems\poker.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] elemLine = line.Split(' ');
                for (int i = 0; i < 5; i++)
                {
                    playerOne.Add(elemLine[i]);
                }
                playerOne.Sort();
                for (int j = 5; j < elemLine.Length; j++)
                {
                    playerTwo.Add(elemLine[j]);
                }
                playerTwo.Sort();
            }
            file.Close();
            return "";
        }

        internal static List<string> SortCard(List<string> cardList)
        {
            List<string> valLsit = new List<string>
                    { "2C", "3C", "4C", "5C", "6C", "7C", "8C", "9C", "TC", "JC", "QC", "KC", "AC",
                      "2D", "3D", "4D", "5D", "6D", "7D", "8D", "9D", "TD", "JD", "QD", "KD", "AD",
                      "2H", "3H", "4H", "5H", "6H", "7H", "8H", "9H", "TH", "JH", "QH", "KH", "AH",
                      "2S", "3S", "4S", "5S", "6S", "7S", "8S", "9S", "TS", "JS", "QS", "KS", "AS",};

            for (int i = 0; i < cardList.Count; i++)
            {
                //if ()
            }
            return valLsit;
        }
    }
}