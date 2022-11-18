using RockPaperScissors.Controllers;
using RockPaperScissors.Utils;

namespace RockPaperScissors.Views
{
    public class GameOverView
    {
        IOutput output;

        public GameOverView(IOutput output)
        {
            this.output = output;
        }

        public void Print(IController controller)
        {
            if (controller.IsGameOver())
                output.WriteLine("GAME WON");
        }
    }
}
