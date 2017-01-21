using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string textInput = Console.ReadLine();

            bool boolValue = Convert.ToBoolean(textInput);

            switch (boolValue)
            {
                case true: Console.WriteLine("Yes");break;
                case false: Console.WriteLine("No");break;
            }
        }
    }
}
