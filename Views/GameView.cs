using RockPaperScissors.Controllers;
using RockPaperScissors.Utils;

namespace RockPaperScissors.Views
{
    class GameView
    {
        IOutput ouput;
        public GameView(IOutput ouput)
        {
            this.ouput = ouput;
        }

        public void Print(IPresenterController presenterController)
        {
            ouput.WriteLine("***** Round: " + presenterController.GetRoundsPlayed() + " *********************\n");
            ouput.WriteLine("Number of Draws: " + presenterController.GetDraws() + "\n");
        }
    }
}
