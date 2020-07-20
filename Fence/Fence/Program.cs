using System;
using System.Linq;

namespace Fence
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }).ToArray();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            if (k > 0 && n > 0)
            {
                var heigth = Console.ReadLine().Split(new[] { ' ' }).Select(str => int.Parse(str)).ToArray();

                if (k == n)
                {
                    Console.WriteLine(1);
                    return;
                }
                int sum = 0;
                int[] totalHeigth = new int[n];

                for (int i = 0; i < n; ++i)
                {
                    sum += heigth[i];
                    totalHeigth[i] = sum;
                }

                int min = totalHeigth[k - 1];
                int index = k - 1;
                for (int i = k; i < n; ++i)
                {
                    if (totalHeigth[i] - totalHeigth[i - k] < min)
                    {
                        min = totalHeigth[i] - totalHeigth[i - k];
                        index = i;
                    }
                }

                    //Array.Clear(totalHeigth, 0, totalHeigth.Length);
                    //int min = 100;
                    //for (int i = 0; i < n; i++)
                    //{
                    //    if (i < k - 1)
                    //        firstTotal += heigth[i];
                    //    else if (i == k - 1)
                    //        totalHeigth[i] = firstTotal + heigth[i];
                    //    else
                    //    {
                    //        totalHeigth[i] = totalHeigth[i - 1] - heigth[i - k] + heigth[i];
                    //    }
                    //}

                    //int index = 0;
                    //for (int i = k - 1; i < n; i++)
                    //{
                    //    if (totalHeigth[i] < min)
                    //    {
                    //        min = totalHeigth[i];
                    //        index = i;
                    //    }
                    //}

                    //int res = index - k + 2;

                    Console.WriteLine(index - k + 2);
                    Console.ReadLine();
                
            }
        }
    }
}
