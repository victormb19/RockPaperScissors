using System;

namespace RockPaperScissors.Models
{
    public class Player
    {
        string name;
        int wins;
        Choice choice;

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

        public Choice GetChoice()
        {
            return choice;
        }

        public void PlayerChoice()
        {
            int randomChoice = random.Next(0,3);
            choice = (Choice)Enum.GetValues(typeof(Choice)).GetValue(randomChoice);
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