using System.Linq;
using RockPaperScissors.Controllers;
using RockPaperScissors.Models;
using RockPaperScissors.Utils;

namespace RockPaperScissors.Views
{

    class PlayerView
    {
        IOutput output;

        public PlayerView(IOutput output)
        {
            this.output = output;
        }

        public void Print(IPresenterController presenterController)
        {
            Player[] players = presenterController.GetPlayers();

            PrintPlayer(players.First());
            PrintPlayer(players[2]);
        }

        private void PrintPlayer(Player player)
        {
            output.WriteLine(player.GetName() + ": " + player.GetChoice() + "\t " + player.GetName() + " Total Wins: " + player.GetWins());
        }
    }
}
