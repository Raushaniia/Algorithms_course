using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coridor
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }).Select(str => int.Parse(str)).ToArray();
            int n = input[0];
            int a = input[1];
            int b = input[2];

            //int A = new KeyValuePair<int, int>(1, a);
            //KeyValuePair<int, int> B = new KeyValuePair<int, int>(3, b);

            int[] f = new int[n + 3];
            f[0] = 0; f[1] = 0; f[2] = 1;

            for (int i = 3; i < n + 3; i++)
            {
                //int m = 0;
                //int k = 0;
                //if (a > 0)
                //{
                //    m = f[i - 1];
                //    a = a - 1;
                //}

                //if (b > 0)
                //{
                //    k = f[i - 3];
                //    b = b - 1;
                //}
                f[i] = f[i - 1] + f[i - 3];
            }

            Console.WriteLine(f[n + 1]);

            Console.ReadLine();
        }
    }
}
