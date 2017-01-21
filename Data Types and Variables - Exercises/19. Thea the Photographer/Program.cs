using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong picturesTaken = ulong.Parse(Console.ReadLine());
            ulong filterTimeInSeconds = ulong.Parse(Console.ReadLine());
            ulong goodPicturesPercentage = ulong.Parse(Console.ReadLine());
            ulong uploadTimeInSeconds = ulong.Parse(Console.ReadLine());

            ulong totalFilterTime =  filterTimeInSeconds * picturesTaken;
            ulong goodPictures = (ulong) Math.Ceiling(goodPicturesPercentage / 100.0 * picturesTaken);
            ulong totalUploadTime = goodPictures * uploadTimeInSeconds;

            ulong totalTimeNeededInSeconds = totalFilterTime + totalUploadTime;

            TimeSpan output = TimeSpan.FromSeconds(totalTimeNeededInSeconds);

            Console.WriteLine("{0:d1}:{1:d2}:{2:d2}:{3:d2}",
                output.Days,
                output.Hours,
                output.Minutes,
                output.Seconds);

        }
    }
}
