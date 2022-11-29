using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputParser_using_delegates
{
    public class Program
    {
        public static void Run(string s,InputParserDelegate onWord, InputParserDelegate onNum, InputParserDelegate onJunk)
        {
            if (s.All(char.IsDigit))
            {
                onNum();
            }
            else if (s.All(char.IsLetterOrDigit))
            {
                onWord();
            }
            else if (!(s.All(char.IsLetterOrDigit)))
            {
                onJunk();
            }
        }
       

        
        static void Main(string[] args)
        {

            string input;
            input = Console.ReadLine();
            Run(input,ConsoleReader.Word,ConsoleReader.Num,ConsoleReader.Junk);


        }
    }
}


