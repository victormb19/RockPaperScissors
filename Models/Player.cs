using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RockPaperScissors.Models
{
    public class Player
    {
        string name;
        int wins;
        Choice choice;

        Random random = new Random(DateTime.Now.Millisecond);

        ReadOnlyDictionary<Choice, Choice> winnerChoice;

        public Player(string name)
        {
            this.name = name;
            wins = 0;
            winnerChoice = new ReadOnlyDictionary<Choice, Choice>( new Dictionary<Choice, Choice>()
            {
                {Choice.paper, Choice.rock },
                {Choice.rock, Choice.scissors },
                {Choice.scissors, Choice.paper },
            });
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
            var choiceValues = Enum.GetValues(typeof(Choice));
            int randomChoice = random.Next(0, choiceValues.Length);
            choice = (Choice)choiceValues.GetValue(randomChoice);
        }

        public void SetWins()
        {
            wins++;
        }

        public int GetWins()
        {
            return wins;
        }

        public bool IsWinnerChoice(Choice choice)
        {
            winnerChoice.TryGetValue(this.choice, out Choice looseChoice);
            return choice == looseChoice;
        }

    }
}