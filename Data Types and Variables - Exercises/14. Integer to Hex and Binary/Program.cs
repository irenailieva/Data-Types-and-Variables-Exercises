﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());

            string hexadecimalNumber = Convert.ToString(decimalNumber, 16).ToUpper();
            string binaryNumber = Convert.ToString(decimalNumber, 2);

            Console.WriteLine($"{hexadecimalNumber}\n{binaryNumber}");
        }
    }
}
