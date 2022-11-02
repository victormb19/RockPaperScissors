using System;

namespace RockPaperScissors.Utils
{
    public class ConsoleOuput: IOuput
    {
        public void WriteLine(string str)
        {
            Console.WriteLine(str);
        }
    }
}
