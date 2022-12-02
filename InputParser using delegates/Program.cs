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
        public void Run(string s,InputParserDelegate onWord, InputParserDelegate onNum, InputParserDelegate onJunk)
        {
            if (s.All(char.IsDigit))
            {
                onNum(s);
            }
            else if (s.All(char.IsLetterOrDigit))
            {
                onWord(s);
            }
            else if (!(s.All(char.IsLetterOrDigit)))
            {
                onJunk(s);
            }
        }
       

        
        static void Main(string[] args)
        {
            while(true)
            {
                Program program = new Program();
                string input;
                input = Console.ReadLine();
                program.Run(input, ConsoleReader.Word, ConsoleReader.Num, ConsoleReader.Junk);
            }
            


        }
    }
}


