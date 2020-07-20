using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangedNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var reposts = Console.ReadLine().Split(new[] { ' ' }).ToArray();
                list1.Add(reposts[0]);
                list2.Add(reposts[1]);
            }

            bool restart = false;
            for (int i = 0; i < list1.Count; i++)
            {
                if (restart)
                {
                    i = 0;
                    restart = false;
                }

                if (list1.Contains(list2[i]))
                {
                    int k = 0 ;
                    for (int j = 0; j < list1.Count; j++)
                    {
                        if (list1[j] == list2[i])
                        {
                            k = j;
                            break;
                        } 
                    }
                    list2[i] = list2[k];
                    list1.RemoveAt(k);
                    list2.RemoveAt(k);

                    restart = true;
                }   
            }

            Console.WriteLine(list1.Count);
            for (int t = 0; t < list1.Count; t++)
            {
                string s = String.Join(" ", list1[t], list2[t]);
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
