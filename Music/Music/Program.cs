using System;
using System.Linq;

namespace CorpAlgoCourse.Spock
{
    public class Music
    {
        private static void Main()
        {
            var items = Console.ReadLine().Split(new[] { ' ' }).Select(str => int.Parse(str)).ToArray();
            int n = items[0];

            int[,] songs = new int[n, 2];
            for (int i = 0; i < n; i++)
            {
                var songProps = Console.ReadLine().Split(new[] { ' ' }).Select(str => int.Parse(str)).ToArray();
                songs[i, 0] = songProps[0];
                songs[i, 1] = songProps[1];
            }

            var time = Console.ReadLine().Split(new[] { ' ' }).Select(str => int.Parse(str)).ToArray();

            
            int totalSongsTime = 0;


            int[] k = new int[n];

            for (int i = 0; i < n; i++)
            {
                totalSongsTime += songs[i, 0] * songs[i, 1];
                k[i] = totalSongsTime;
            }

            int[] songTime = new int[time.Count()];

            for (int i = 0; i < time.Count(); i++)
            {
                var songChangeTime = Array.BinarySearch(k, time[i]);
                if (songChangeTime < 0)
                {
                    songTime[i] = ~songChangeTime + 1;
                }
                else
                {
                    songTime[i] = songChangeTime + 1;
                }
            }

            foreach (var s in songTime)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}