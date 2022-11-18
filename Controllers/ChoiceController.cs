using RockPaperScissors.Models;

namespace RockPaperScissors.Controllers
{
    public abstract class ChoiceController: IPresenterController
    {
        protected Game game;

        public ChoiceController()
        {
            game = new Game();
        }

        public abstract void SetChoice();

        public int GetRoundsPlayed()
        {
            return game.GetRoundsPlayed();
        }

        public int GetDraws()
        {
            return game.GetDraws();
        }

        public bool IsGameOver()
        {
            return game.IsGameOver();
        }

        public Player[] GetPlayers()
        {
            return game.GetPlayers();
        }

        public bool IsDraw()
        {
            return game.IsDraw();
        }

        public string GetPlayerWinnerName()
        {
            return game.RoundWinner().GetName();
        }

        public void AddRoundsPlayed()
        {
            game.AddRoundPlayed();
        }

        public void SetChoices(Choice choicePlayer1, Choice choicePlayer2)
        {
            game.SetChoices(choicePlayer1, choicePlayer2);
            if (!game.IsGameOver())
                game.AddRoundPlayed();
        }
    }
}
