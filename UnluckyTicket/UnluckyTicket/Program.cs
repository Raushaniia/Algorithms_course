using System;
using System.Linq;

namespace UnluckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().ToArray();
            int[] numbers = new int[2*n];
            int[] numbersFirst = new int[n];
            int[] numbersSecond = new int[n];
            for (int i = 0; i < 2*n; i++)
            {
                numbers[i] = int.Parse(input[i].ToString());
            }

            numbersFirst = numbers.Take(n).ToArray();
            Array.Sort(numbersFirst);

            numbersSecond = numbers.Skip(n).Take(n).ToArray();
            Array.Sort(numbersSecond);
            int k = 0;
            if (numbersFirst[0] > numbersSecond[0])
            {
                k = 1;
                for (int i = 1; i < n; i++)
                {
                    if (numbersFirst[i] > numbersSecond[i])
                    {
                        k++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (numbersFirst[0] < numbersSecond[0])
            {
                k = 1;
                for (int i = 1; i < n; i++)
                {
                    if (numbersFirst[i] < numbersSecond[i])
                    {
                        k++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (k == n)
                Console.WriteLine("YES");
            else
            {
                Console.WriteLine("NO");
            }

            Console.ReadLine();
        }
    }
}
