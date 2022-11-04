using System;
using RockPaperScissors.Models;

namespace RockPaperScissors.Controllers
{
    public class RandomChoiceController: IChoiceController
    {
        Random random;

        public RandomChoiceController()
        {
            random = new Random(DateTime.Now.Millisecond);
        }

        public Choice GetChoice()
        {
            var choiceValues = Enum.GetValues(typeof(Choice));
            int randomChoice = random.Next(0, choiceValues.Length);
            return (Choice)choiceValues.GetValue(randomChoice);
        }
    }
}
