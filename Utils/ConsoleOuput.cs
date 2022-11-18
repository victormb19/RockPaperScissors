using System;

namespace RockPaperScissors.Utils
{
    public class ConsoleOuput: IOutput
    {
        public void WriteLine(string str)
        {
            Console.WriteLine(str);
        }
    }
}
