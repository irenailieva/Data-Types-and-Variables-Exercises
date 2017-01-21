using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            object concatenation = $"{firstInput} {secondInput}";

            string output = (string)concatenation;

            Console.WriteLine(output);

        }
    }
}
