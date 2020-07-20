using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termination
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[2];
            input = Console.ReadLine().Split(new[] { ' ' }).Select(v => int.Parse((string)v)).ToArray();
            int n = input[0];
            int m = input[1];

            boolean[][] f = new boolean[100][100];
            f[0][0] = true;
            for (int i = 1; i < n + 1; i++)
                for (int s = 0; s <= K; s++)
                {
                    f[i][s] = f[i - 1][s];
                    if (s - a[i - 1] >= 0)
                        f[i][s] = f[i][s] || f[i - 1][s - a[i - 1]];
                }
            System.out.println(f[n][k] ? “YES” : “NO”);
        }
    }
}
