using System;
using RockPaperScissors.Utils;

namespace RockPaperScissors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new RockPaperScissor(new ConsoleOuput()).Play();
        }
    }

    public class Player
    {

        public int wins;      // # of wins
        Random random = new Random(DateTime.Now.Millisecond);

        /**
         * Randomly choose rock, paper, or scissors
         */
        public string PlayerChoice()
        {
            string choice = "";
            int c = random.Next(0,3);
            switch (c)
            {
                case 0:
                    choice = ("rock");
                    break;
                case 1:
                    choice = ("paper");
                    break;
                case 2:
                    choice = ("scissors");
                    break;
            }
            return choice;
        }

        public int SetWins()
        {
            int winTotal = wins++;
            return winTotal;
        }

        public int GetWins()
        {
            return (wins);
        }
    }
}