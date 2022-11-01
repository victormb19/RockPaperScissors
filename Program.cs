using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
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
                Console.WriteLine("***** Round: " +
                    roundsPlayed + " *********************\n");
                Console.WriteLine("Number of Draws: " +
                    draw + "\n");
                p1Choice = p1.PlayerChoice();
                Console.WriteLine("Player 1: " + p1Choice +
                    "\t Player 1 Total Wins: " + p1Wins);
                p2Choice = p2.PlayerChoice();
                Console.WriteLine("Player 2: " + p2Choice +
                    "\t Player 2 Total Wins: " + p2Wins);
                if ((p1Choice.Equals("rock")) && (p2Choice.Equals("paper")))
                {
                    Console.WriteLine("Player 2 Wins");
                    p2Wins++;  // trying a couple different ways to get count to work
                }
                else if ((p1Choice.Equals("paper")) && (p2Choice.Equals("rock")))
                {
                    p1Wins++;
                    Console.WriteLine("Player 1 Wins");
                }
                else if ((p1Choice.Equals("rock")) && (p2Choice.Equals("scissors")))
                {
                    p1Wins = p1.SetWins();
                    Console.WriteLine("Player 1 Wins");
                }
                else if ((p1Choice.Equals("scissors")) && (p2Choice.Equals("rock")))
                {
                    p2Wins = p2.SetWins();
                    Console.WriteLine("Player 2 Wins");
                }
                else if ((p1Choice.Equals("scissors")) && (p2Choice.Equals("paper")))
                {
                    p1Wins = p1.SetWins();
                    Console.WriteLine("Player 1 Wins");
                }
                else if ((p1Choice.Equals("paper")) && (p2Choice.Equals("scissors")))
                {
                    p2Wins = p2.SetWins();
                    Console.WriteLine("Player 2 Wins");
                }
                if (p1Choice == p2Choice)
                {
                    draw++;
                    Console.WriteLine("\n\t\t\t Draw \n");
                }
                roundsPlayed++;
                if ((p1.GetWins() >= 3) || (p2.GetWins() >= 3))
                {
                    gameWon = true;
                    Console.WriteLine("GAME WON");
                }
                Console.WriteLine();
            } while (gameWon != true);
        }
    }

    public class Player
    {

        public int wins;      // # of wins
        int winTotal;
        Random random = new Random();

        /**
         * Randomly choose rock, paper, or scissors
         */
        public string PlayerChoice()
        {
            string choice = "";
            int c = random.Next(0,3);
            switch (c)
            {
                case 0:
                    choice = ("rock");
                    break;
                case 1:
                    choice = ("paper");
                    break;
                case 2:
                    choice = ("scissors");
                    break;
            }
            return choice;
        }

        public int SetWins()
        {
            int winTotal = wins++;
            return winTotal;
        }

        public int GetWins()
        {
            return (wins);
        }
    }
}