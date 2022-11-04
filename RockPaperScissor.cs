using RockPaperScissors.Controllers;
using RockPaperScissors.Models;
using RockPaperScissors.Utils;

namespace RockPaperScissors
{
    public class RockPaperScissor
    {
        const int GAME_WON = 3;
        IOuput io;
        IChoiceController choiceController;


        public RockPaperScissor(IOuput io, IChoiceController choiceController)
        {
            this.io = io;
            this.choiceController = choiceController;
        }

        public void Play()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");
            int roundsPlayed = 0;    // Number of rounds played
            int draw = 0;
            // Game Loop
            do
            {
                WriteLine("***** Round: " +
                    roundsPlayed + " *********************\n");
                WriteLine("Number of Draws: " +
                    draw + "\n");
                player1.SetChoice(choiceController.GetChoice());
                WriteLine(player1.GetName() + ": " + player1.GetChoice() +
                    "\t " + player1.GetName() + " Total Wins: " + player1.GetWins());
                player2.SetChoice(choiceController.GetChoice());
                WriteLine(player2.GetName() + ": " + player2.GetChoice() +
                    "\t " + player2.GetName() + " Total Wins: " + player2.GetWins());

                RoundWinner(player1, player2);
                RoundWinner(player2, player1);
                draw += Draw(player1.GetChoice(), player2.GetChoice());
                roundsPlayed++;
                WriteLine(string.Empty);
            } while (IsGameOver(player1, player2) != true);
            WriteLine("GAME WON");
        }

        private void RoundWinner(Player player, Player enemy)
        {
            if (player.IsWinnerChoice(enemy.GetChoice()))
            {
                player.SetWins();
                WriteLine(player.GetName() + " Wins");
            }
        }

        private int Draw(Choice choice, Choice otherChoice)
        {
            if (choice == otherChoice)
            {
                WriteLine("\n\t\t\t Draw \n");
                return 1;
            }

            return 0;
        }

        private bool IsGameOver(Player p1, Player p2)
        {
            return (p1.GetWins() >= GAME_WON) || (p2.GetWins() >= GAME_WON);
        }

        private void WriteLine(string str)
        {
            io.WriteLine(str);
        }
    }
}
