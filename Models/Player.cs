using System;

namespace RockPaperScissors.Models
{
    public class Player
    {
        string name;
        public int wins;      // # of wins
        Random random = new Random(DateTime.Now.Millisecond);

        public Player(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        /**
         * Randomly choose rock, paper, or scissors
         */
        public string PlayerChoice()
        {
            int randomChoice = random.Next(0,3);
            string choice = Enum.GetValues(typeof(Choice)).GetValue(randomChoice).ToString();
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