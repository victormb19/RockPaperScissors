﻿using RockPaperScissors.Models;
using RockPaperScissors.Utils;

namespace RockPaperScissors
{
    public class RockPaperScissor
    {
        const int GAME_WON = 3;
        IOuput io;

        public RockPaperScissor(IOuput io)
        {
            this.io = io;
        }

        public void Play()
        {
            Player p1 = new Player("Player 1");
            Player p2 = new Player("Player 2");
            int roundsPlayed = 0;    // Number of rounds played
            int draw = 0;
            // Game Loop
            do
            {
                WriteLine("***** Round: " +
                    roundsPlayed + " *********************\n");
                WriteLine("Number of Draws: " +
                    draw + "\n");
                p1.PlayerChoice();
                WriteLine(p1.GetName() + ": " + p1.GetChoice() +
                    "\t " + p1.GetName() + " Total Wins: " + p1.GetWins());
                p2.PlayerChoice();
                WriteLine(p2.GetName() + ": " + p2.GetChoice() +
                    "\t " + p2.GetName() + " Total Wins: " + p2.GetWins());

                RoundWinner(p1, p2);
                RoundWinner(p2, p1);
                draw += Draw(p1.GetChoice(), p2.GetChoice());
                roundsPlayed++;
                WriteLine(string.Empty);
            } while (IsGameOver(p1, p2) != true);
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
