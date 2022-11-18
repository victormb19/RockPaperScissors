using System;
using RockPaperScissors.Models;

namespace RockPaperScissors.Controllers
{
    public class RandomChoiceController: ChoiceController
    {
        Random random;

        public RandomChoiceController()
        {
            random = new Random(DateTime.Now.Millisecond);
        }

        public override void SetChoice()
        {
            var choiceValues = Enum.GetValues(typeof(Choice));
            int randomChoice = random.Next(0, choiceValues.Length);
            game.SetPlayerChoice((Choice)choiceValues.GetValue(randomChoice));
        }
    }
}
