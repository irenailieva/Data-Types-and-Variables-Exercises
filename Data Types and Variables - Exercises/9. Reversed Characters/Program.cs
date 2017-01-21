using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Reversed_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstChar = Console.ReadLine();
            string secondChar = Console.ReadLine();
            string thirdChar = Console.ReadLine();

            object reversedChars = $"{thirdChar}{secondChar}{firstChar}";
            string output = (string)reversedChars;

            Console.WriteLine(output);
        }
    }
}
