using System;
using System.Collections.Generic;

namespace Get3SumBestTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = new List<int>() { -30, -4, 0, 1, 2, 4, 5, 7,8 };
            var B = 1;

            threeSumClosest(A, B);

        }

        public static void threeSumClosest(List<int> A, int B)
        {
            A.Sort();
            long bestTarget = Int32.MaxValue;
            long minDelta = Int32.MaxValue;
            int n1 = Int32.MaxValue;
            int n2 = Int32.MaxValue;
            int n3 = Int32.MaxValue;

            for (int i = 0; i < A.Count; i++)
            {
                int start = 0;
                int end = A.Count - 1;

                long expectedSum = Math.Abs(B - A[i]);
                while (start < end)
                {
                    if (start == i)
                    {
                        start++;
                        continue;
                    }

                    if (end == i)
                    {
                        end--;
                        continue;
                    }

                    if (minDelta > Math.Abs((long)(A[start] + A[end] + A[i]) - (long)B))
                    {
                        bestTarget = A[start] + A[end] + A[i];
                        minDelta = Math.Min(minDelta, Math.Abs((long)(A[start] + A[end] + A[i]) - (long)B));
                        n1 = A[start];
                        n2 = A[end];
                        n3 = A[i];
                    }

                    if (A[start] + A[end] < expectedSum)
                        start++;
                    else if (A[start] + A[end] > expectedSum)
                    {
                        end--;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("bestTarget = " + bestTarget);
            Console.WriteLine("n1 = " + n1);
            Console.WriteLine("n2 = " + n2);
            Console.WriteLine("n3 = " + n3);
            Console.ReadLine();
        }
    }
}
