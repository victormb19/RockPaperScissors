﻿using RockPaperScissors.Utils;

namespace RockPaperScissors
{
    public class RockPaperScissor
    {
        IOuput io;

        public RockPaperScissor(IOuput io)
        {
            this.io = io;
        }

        public void Play()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            bool gameWon = false;
            int roundsPlayed = 0;    // Number of rounds played
            int p1Wins = p1.wins;
            int p2Wins = p2.wins;
            int draw = 0;
            string p1Choice;
            string p2Choice;
            // Game Loop
            do
            {
                WriteLine("***** Round: " +
                    roundsPlayed + " *********************\n");
                WriteLine("Number of Draws: " +
                    draw + "\n");
                p1Choice = p1.PlayerChoice();
                WriteLine("Player 1: " + p1Choice +
                    "\t Player 1 Total Wins: " + p1Wins);
                p2Choice = p2.PlayerChoice();
                WriteLine("Player 2: " + p2Choice +
                    "\t Player 2 Total Wins: " + p2Wins);
                if ((p1Choice.Equals("rock")) && (p2Choice.Equals("paper")))
                {
                    WriteLine("Player 2 Wins");
                    p2Wins++;  // trying a couple different ways to get count to work
                }
                else if ((p1Choice.Equals("paper")) && (p2Choice.Equals("rock")))
                {
                    p1Wins++;
                    WriteLine("Player 1 Wins");
                }
                else if ((p1Choice.Equals("rock")) && (p2Choice.Equals("scissors")))
                {
                    p1Wins = p1.SetWins();
                    WriteLine("Player 1 Wins");
                }
                else if ((p1Choice.Equals("scissors")) && (p2Choice.Equals("rock")))
                {
                    p2Wins = p2.SetWins();
                    WriteLine("Player 2 Wins");
                }
                else if ((p1Choice.Equals("scissors")) && (p2Choice.Equals("paper")))
                {
                    p1Wins = p1.SetWins();
                    WriteLine("Player 1 Wins");
                }
                else if ((p1Choice.Equals("paper")) && (p2Choice.Equals("scissors")))
                {
                    p2Wins = p2.SetWins();
                    WriteLine("Player 2 Wins");
                }
                if (p1Choice == p2Choice)
                {
                    draw++;
                    WriteLine("\n\t\t\t Draw \n");
                }
                roundsPlayed++;
                if ((p1.GetWins() >= 3) || (p2.GetWins() >= 3))
                {
                    gameWon = true;
                    WriteLine("GAME WON");
                }
                WriteLine(string.Empty);
            } while (gameWon != true);
        }

        private void WriteLine(string str)
        {
            io.WriteLine(str);
        }
    }
}
