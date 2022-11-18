using RockPaperScissors.Controllers;
using RockPaperScissors.Utils;

namespace RockPaperScissors.Views
{
    public class RockPaperScissorView: IView
    {
        GameView gameView;
        PlayerView playerView;
        RoundResolutionView roundResolutionView;
        GameOverView gameOverView;

        public RockPaperScissorView(IOutput output)
        {
            gameView = new GameView(output);
            playerView = new PlayerView(output);
            roundResolutionView = new RoundResolutionView(output);
            gameOverView = new GameOverView(output);
        }

        public void Print(IController controller)
        {
            gameView.Print((IPresenterController)controller);
            playerView.Print((IPresenterController)controller);
            roundResolutionView.Print((IPresenterController)controller);
            gameOverView.Print(controller);
        }
    }
}
