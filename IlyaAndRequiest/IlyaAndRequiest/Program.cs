using System;
using System.Linq;

namespace IlyaAndRequiest
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] signs = Console.ReadLine().ToCharArray();
            int n = int.Parse(Console.ReadLine());
            int[,] input = new int[n, 2];

            for (int i = 0; i < n; i++)
            {
                var p = Console.ReadLine().Split(new[] { ' ' }).Select(v => int.Parse((string)v)).ToArray();
                input[i, 0] = p[0];
                input[i, 1] = p[1];
            }

            int l = signs.Length;
            int[] result = new int[l];
            result[0] = 0;
            for (int j = 1; j < l; j++)
            {
                if (signs[j - 1] == signs[j])
                {
                    result[j] = result[j -1] + 1;
                }
                else
                {
                    result[j] = result[j - 1];
                }
            }
            for (int i = 0; i < n; i++)
            {
                int t = result[input[i, 1] - 1] - result[input[i, 0] -1];
                
                Console.WriteLine(t);
            }
            //for (int i = 0; i < n; i++)
            //{

            //    //int k = 0;
            //    //for (int j = input[i, 0]; j < input[i, 1]; j++)
            //    //{
            //    //    if (signs[j - 1] == signs[j])
            //    //    {
            //    //        k++;
            //    //    }
            //    //}

            //    //Console.WriteLine(k);
            //}

            Console.ReadLine();
        }
    }
}
