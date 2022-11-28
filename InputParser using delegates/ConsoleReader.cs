using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputParser_using_delegates
{
    public class ConsoleReader
    {
        public void Run()
        {
            string input;
            input = Console.ReadLine();
        }
        public delegate void onWord();
        public delegate void onNumber();
        public delegate void onJunk();

        public void Word()
        {
            Console.WriteLine("input string contains group of words");
            Console.ReadLine();
        }
        public void Num()
        {
            Console.WriteLine("input string contains group of numbers");
            Console.ReadLine();
        }
        public void Junk()
        {
            Console.WriteLine("input string contains special characters");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            ConsoleReader reader = new ConsoleReader();
            onWord onword = new onWord(reader.Word);
            onNumber onnumber = new onNumber(reader.Num);
            onJunk onjunk = new onJunk(reader.Junk);

            string input;
            input = Console.ReadLine();
            if(input.All(char.IsDigit) )
            {
                onnumber();
            }
            else if (input.All(char.IsLetterOrDigit))
            {
                onword();
            }
            else if(!(input.All(char.IsLetterOrDigit) )) 
            {
                onjunk();
            }


        }
    }
}


