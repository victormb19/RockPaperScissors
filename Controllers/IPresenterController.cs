using RockPaperScissors.Models;

namespace RockPaperScissors.Controllers
{
    public interface IPresenterController: IController
    {
        int GetRoundsPlayed();
        int GetDraws();
        Player[] GetPlayers();
        bool IsDraw();
        string GetPlayerWinnerName();
    }
}
