using RockPaperScissors.Controllers;
using RockPaperScissors.Utils;

namespace RockPaperScissors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new RockPaperScissor(new ConsoleOuput(), new RandomChoiceController()).Play();
        }
    }
}