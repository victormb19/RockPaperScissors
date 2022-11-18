using RockPaperScissors.Controllers;
using RockPaperScissors.Utils;

namespace RockPaperScissors.Views
{
    class RoundResolutionView
    {
        IOutput output;

        public RoundResolutionView(IOutput output)
        {
            this.output = output;
        }

        public void Print(IPresenterController presenterController)
        {
            if (presenterController.IsDraw())
               output.WriteLine("\n\t\t\t Draw \n");
            else
               output.WriteLine(presenterController.GetPlayerWinnerName() + " Wins");

            output.WriteLine(string.Empty);
        }
    }
}
