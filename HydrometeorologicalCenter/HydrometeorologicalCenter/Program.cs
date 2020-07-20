using System;
using System.Linq;

namespace HydrometeorologicalCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            input = Console.ReadLine().Split(new[] { ' ' }).Select(v => int.Parse((string)v)).ToArray();
            int max = 0;
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (input[i] < 0 && input[i] % 2 == 0)
                {
                    k++;
                }
                else
                {
                    k = 0;
                }
                if (k > max)
                {
                    max = k;
                }
            }

            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
