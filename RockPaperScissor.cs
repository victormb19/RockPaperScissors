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
                WriteLine(p1.GetName() + ": " + p1Choice +
                    "\t " + p1.GetName() + " Total Wins: " + p1.GetWins());
                p2Choice = p2.PlayerChoice();
                WriteLine(p2.GetName() + ": " + p2Choice +
                    "\t " + p2.GetName() + " Total Wins: " + p2.GetWins());

                if (((p1Choice.Equals("paper")) && (p2Choice.Equals("rock"))) || (p1Choice.Equals("rock")) && (p2Choice.Equals("scissors")) || ((p1Choice.Equals("scissors")) && (p2Choice.Equals("paper"))))
                {
                    p1.SetWins();
                    WriteLine(p1.GetName() + " Wins");
                }
                else if (((p1Choice.Equals("rock")) && (p2Choice.Equals("paper"))) || (p1Choice.Equals("scissors")) && (p2Choice.Equals("rock")) || ((p1Choice.Equals("paper")) && (p2Choice.Equals("scissors"))))
                {
                    p2.SetWins();
                    WriteLine(p2.GetName() + " Wins");
                }
                draw += Draw(p1Choice, p2Choice);
                roundsPlayed++;
                WriteLine(string.Empty);
            } while (IsGameOver(p1, p2) != true);
            WriteLine("GAME WON");
        }

        private int Draw(string choice, string otherChoice)
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
