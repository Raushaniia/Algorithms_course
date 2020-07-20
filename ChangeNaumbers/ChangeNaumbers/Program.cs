using System;
using System.Linq;
using System.Text;

namespace ChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = Console.ReadLine().Split(new[] { ' ' }).Select(v => int.Parse((string)v)).ToArray();
            string g = (Console.ReadLine());
            int n = p[0];
            int k = p[1];
            if (k == 0)
            {
                Console.WriteLine(g);
            }
            else
            {
                var s = GetRes(g, k, n);
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }

        public static StringBuilder GetRes(string g, int k, int n)
        {
            StringBuilder sb = new StringBuilder();
            if (k > 0 && n == 1)
            {
                return sb.Append('0');
            }

            if (g[0] != '1')
            {
                k--;
            }

            sb.Append('1');

            for (int j = 1; j < g.Length; j++)
            {
                if (k == 0)
                {
                   // sb.Append('0');
                    sb.Append(g.Substring(j , g.Length - j));
                    return sb;
                }

                if (g[j] == '0')
                {
                    sb.Append(g[j]);
                }
                else
                {
                    sb.Append('0');
                    k--;
                }
            }

            return sb;
        }
    }
}

