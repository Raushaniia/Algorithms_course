using System;
using System.Collections.Generic;
using System.Linq;

namespace ExchangeApplications
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split(new[] { ' ' }).ToArray();
            SortedDictionary<int, int> sales = new SortedDictionary<int, int>();
            SortedDictionary<int, int> bougtes = new SortedDictionary<int, int>();

            for (int i = 0; i < int.Parse(n[0]); i++)
            {
                var allDeals = Console.ReadLine().Split(new[] { ' ' }).ToArray();
                if (allDeals[0] == "S")
                {
                    if (!sales.Keys.Contains(int.Parse(allDeals[1])))
                    {
                        sales.Add(int.Parse(allDeals[1]), int.Parse(allDeals[2]));
                    }
                    else
                    {
                        var el = sales.Where(x => x.Key == int.Parse(allDeals[1])).FirstOrDefault();
                        var r = el.Value;

                        sales[int.Parse(allDeals[1])] = r + int.Parse(allDeals[2]);
                    }
                }
                if (allDeals[0] == "B")
                {
                    if (!bougtes.Keys.Contains(int.Parse(allDeals[1])))
                    {
                        bougtes.Add(int.Parse(allDeals[1]), int.Parse(allDeals[2]));
                    }
                    else
                    {
                        var el = bougtes.Where(x => x.Key == int.Parse(allDeals[1])).FirstOrDefault();
                        var r = el.Value;

                        bougtes[int.Parse(allDeals[1])] = r + int.Parse(allDeals[2]);
                    }
                }
            }

            var list = new Dictionary<int, int>();
            for (int i = 0; i < int.Parse(n[1]); i++)
            {
                if (sales.Keys.Count > i)
                    list.Add(sales.Keys.ElementAt(i), sales.Values.ElementAt(i));
            }
            for (int i = 0; i < int.Parse(n[1]); i++)
            {
                if (list.Keys.Count > i)
                    Console.WriteLine($"S {list.Keys.Reverse().ElementAt(i)} {list.Values.Reverse().ElementAt(i)}");
            }

            for (int i = 0; i < int.Parse(n[1]); i++)
            {
                if (bougtes.Keys.Count > i)
                    Console.WriteLine($"B {bougtes.Keys.Reverse().ElementAt(i)} {bougtes.Values.Reverse().ElementAt(i)}");
            }

            Console.ReadLine();
        }
    }
}
