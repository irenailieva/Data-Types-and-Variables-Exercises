using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingValue = int.Parse(Console.ReadLine());
            int endingValue = int.Parse(Console.ReadLine());

            for (int currentValue = startingValue; currentValue <= endingValue; currentValue++)
            {
                char symbol = Convert.ToChar(currentValue);
                Console.Write(symbol + " ");
            }

            Console.WriteLine();
        }
    }
}
