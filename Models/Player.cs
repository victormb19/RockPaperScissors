using System;

namespace RockPaperScissors.Models
{
    public class Player
    {
        string name;
        int wins;
        Random random = new Random(DateTime.Now.Millisecond);

        public Player(string name)
        {
            this.name = name;
            wins = 0;
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
            return Enum.GetValues(typeof(Choice)).GetValue(randomChoice).ToString();
        }

        public void SetWins()
        {
            wins++;
        }

        public int GetWins()
        {
            return wins;
        }
    }
}