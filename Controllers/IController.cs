using RockPaperScissors.Models;

namespace RockPaperScissors.Controllers
{
    public interface IController
    {
        void AddRoundsPlayed();
        bool IsGameOver();
    }
}
