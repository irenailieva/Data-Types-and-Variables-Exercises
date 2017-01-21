using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {

            var integer = Console.ReadLine();


            bool fitsInSbyte = true;
            bool fitsInByte = true;
            bool fitsInShort = true;
            bool fitsInUshort = true;
            bool fitsInInt = true;
            bool fitsInUint = true;
            bool fitsInLong = true;


            try { sbyte.Parse(integer); } catch { fitsInSbyte = false; }

            try { byte.Parse(integer); } catch { fitsInByte = false; }

            try { short.Parse(integer); } catch { fitsInShort = false; }

            try { ushort.Parse(integer); } catch { fitsInUshort = false; }

            try { int.Parse(integer); } catch { fitsInInt = false; }

            try { uint.Parse(integer); } catch { fitsInUint = false; }

            try { long.Parse(integer); } catch { fitsInLong = false; }


            if (fitsInSbyte == false && fitsInByte == false && fitsInShort == false && fitsInUshort == false && fitsInInt == false && fitsInUint == false && fitsInLong == false)
            {
                Console.WriteLine($"{integer} can't fit in any type");
            }

            else
            {
                Console.WriteLine($"{integer} can fit in:");
                if (fitsInSbyte == true) Console.WriteLine("* sbyte");
                if (fitsInByte == true) Console.WriteLine("* byte");
                if (fitsInShort == true) Console.WriteLine("* short");
                if (fitsInUshort == true) Console.WriteLine("* ushort");
                if (fitsInInt == true) Console.WriteLine("* int");
                if (fitsInUint == true) Console.WriteLine("* uint");
                if (fitsInLong == true) Console.WriteLine("* long");
            }


        }
    }
}
