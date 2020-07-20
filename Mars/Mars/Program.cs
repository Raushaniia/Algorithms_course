using System;
using System.Linq;

namespace Mars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] input = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                var p = Console.ReadLine().Split(new[] { ' ' }).Select(v => int.Parse((string)v)).ToArray();

                for (int j = 0; j < n; j++)
                {
                    input[i, j] = p[j];
                }
            }

            int[,] f = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int m = 0, k = 0;
                    if (i - 1 >= 0)
                        m = f[i - 1, j];

                    if (j - 1 >= 0)
                        k = f[i, j - 1];

                    f[i, j] = Math.Max(m, k) + input[i, j];
                }
            }
            Console.WriteLine(f[n - 1 ,n - 1]);
            Console.ReadLine();
        }
    }
}
