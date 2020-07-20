using System;
using System.Linq;
using System.Collections.Generic;

namespace Repost
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string , int> d = new Dictionary<string, int>();
            d.Add("polycarp", 1);
            for (int i = 0; i < n; i++)
            {
                var songProps = Console.ReadLine().Split(new[] { ' ' }).ToArray();
                if (d.Keys.Contains(songProps[2].ToLower()))
                {
                    var el = d.Where(x => x.Key.ToLower() == songProps[2].ToLower()).FirstOrDefault();
                    var r = el.Value;

                    d.Add(songProps[0].ToLower(), r+1);
                }
            }

            Console.WriteLine(d.Values.Max());
            Console.ReadLine();
        }
    }
}
