using System.Linq;

namespace RockPaperScissors.Models
{
    public class Game
    {
        const int GAME_WON = 3;

        int roundsPlayed;
        int draw;
        Player [] players;

        int playerTurn;

        public Game()
        {
            roundsPlayed = 0;
            draw = 0;
            players = new Player[]
            {
                new Player("Player 1"),
                new Player("Player 2")
            };
            playerTurn = 0;
        }

        public void SetPlayerChoice(Choice choice)
        {
            players[playerTurn].SetChoice(choice);
        }

        internal void ChangeTurn()
        {
            playerTurn= (playerTurn+1) % 2;
        }

        internal int GetDraws()
        {
            return draw;
        }

        internal int GetRoundsPlayed()
        {
            return roundsPlayed;
        }

        public Player[] GetPlayers()
        {
            return players;
        }

        public Player RoundWinner()
        {
            if (players.First().IsWinnerChoice(players[1].GetChoice()))
            {
                players.First().SetWins();
                return players.First();
            }
            players[1].SetWins();
            return players[1];
        }

        internal void AddRoundPlayed()
        {
            roundsPlayed++;
        }

        public bool IsDraw()
        {
            bool result = players.First().GetChoice() == players[1].GetChoice();
            if(result) 
                draw++; 
            return result;
        }

        public bool IsGameOver()
        {
            return (players.First().GetWins() >= GAME_WON) || (players[1].GetWins() >= GAME_WON);
        }
    }
}
