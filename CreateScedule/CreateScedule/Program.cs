using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateScedule
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = new List<int>() { 1};
            var B = new List<int>() { 1 };
            var C = 1;

            var result = hotel(A,B,C);
            Console.WriteLine(result);
            Console.ReadLine();
        }


        public static int hotel(List<int> A, List<int> B, int C)
        {
            var sced = new List<KeyValuePair<int, bool>>();

            // true -> check in
            // false -> check out
            int k = 0;
            for (int i = 0; i < A.Count; i++)
            {
                sced.Add(new KeyValuePair<int, bool>(A.ElementAt(i), true));
                sced.Add(new KeyValuePair<int, bool>(B.ElementAt(i), false));
            }

            sced.Sort((x, y) => (y.Value.CompareTo(x.Value)));
            sced.Sort((x, y) => (y.Key.CompareTo(x.Key)));
            

            for (int i = sced.Count - 1; i >= 0; i--)
            {
                if (sced.ElementAt(i).Value)
                    k++;
                else
                    k--;

                if (k > C)
                    return 0;
            }

            return 1;
        }
    }
}
