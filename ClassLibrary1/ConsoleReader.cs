using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public delegate void InputParserDelegate();
    public class ConsoleReader
    {
        InputParserDelegate onWord = Word;
        InputParserDelegate onNum = Num;
        InputParserDelegate onJunk = Junk;

        public static  void Word()
        {
            Console.WriteLine("input string contains group of words : called onWord");
            Console.ReadLine();
        }
        public static void Num()
        {
            Console.WriteLine("input string contains group of numbers : called onNum");
            Console.ReadLine();
        }
        public static void Junk()
        {
            Console.WriteLine("input string contains special characters : called onJunk");
            Console.ReadLine();
        }
    }
}
