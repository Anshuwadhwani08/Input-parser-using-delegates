using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public delegate string InputParserDelegate(string s);
    public class ConsoleReader
    {
        InputParserDelegate onWord = Word;
        InputParserDelegate onNum = Num;
        InputParserDelegate onJunk = Junk;

        public static string Word(string op)
        {
             op = "input string contains group of words : called onWord";
            Console.WriteLine(op);
            return op;
            
        }
        public static string Num(string op)
        {
            
            op = "input string contains group of numbers: called onNum";
            Console.WriteLine(op);
            return op;
        }
        public static string Junk(string op)
        {
           
            op = "input string contains special characters : called onJunk";
            Console.WriteLine(op);
            return op;
        }
    }
}
