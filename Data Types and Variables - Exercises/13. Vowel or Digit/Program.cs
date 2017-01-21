using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            char symbol = Convert.ToChar(input);
            int symbolValue = Convert.ToInt32(symbol);

            switch (symbolValue)
            {
                case 48: 
                case 49: 
                case 50: 
                case 51: 
                case 52: 
                case 53: 
                case 54:
                case 55: 
                case 56: 
                case 57: Console.WriteLine("digit");break;
                case 97: 
                case 101: 
                case 105:
                case 111:
                case 117: Console.WriteLine("vowel");break;
                default: Console.WriteLine("other");break;

            }

        }
    }
}
