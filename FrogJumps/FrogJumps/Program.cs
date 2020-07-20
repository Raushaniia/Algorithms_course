using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogJumps
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = Console.ReadLine().Split(new[] { ' ' }).Select(v => int.Parse((string)v)).ToArray();
            string g = (Console.ReadLine());
            int n = p[0];
            int d = p[1];

            var r = GetNumberOfJumps(g, d);
            Console.WriteLine(r);

            Console.ReadLine();
        }

        private static int GetNumberOfJumps(string g, int d)
        {
            int result = GetLenghtOfJumps(g, d);

            if (result == -1)
                return -1;

            int k = 0;
            int j = 0;
            while (j < g.Length -1)
            {
                if (g[j] == '1')
                {
                    j = j + d;
                    k++;
                }
                else
                {
                    j--;
                }
            }

            return k;
        }

        private static int GetLenghtOfJumps(string g, int d)
        {
            List<int> result = new List<int>();
            int l = 1;
            for (int i = 0; i < g.Length; i++)
            {
                if (g[i] == '1')
                {

                    l = 0;
                }
                else
                {
                    l++;

                    if (l >= d)
                        return -1;
                }
            }

            return 0;
        }
    }
}
