using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            //METERS PER SECOND:
            float totalTimeInSeconds = hours * 3600.0f + minutes * 60.0f + seconds;
            Console.WriteLine(distanceInMeters / totalTimeInSeconds);

            //KILOMETERS PER HOUR:
            float totalTimeInHours = hours + minutes / 60.0f + seconds / 3600.0f;
            Console.WriteLine(distanceInMeters / 1000.0f / totalTimeInHours);

            //MILES PER HOUR:
            Console.WriteLine(distanceInMeters / 1609.0f / totalTimeInHours);
        }
    }
}
