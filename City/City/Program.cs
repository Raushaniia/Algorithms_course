using System;
using System.Collections.Generic;
using System.Linq;

namespace CorpAlgoCourse.Spock
{
    public class City
    {

        private static double CalculateMinimumRadiusToExpandForBecomingMegaCity(int tomskPopulation, int[,] nearbyTowns, int n)
        {
            var nearbyTownsOrderedByDistance = new SortedDictionary<double, int>();

            for (int i = 0; i < n; i++)
            {
                var currentRadius = Math.Sqrt(Math.Pow(nearbyTowns[i, 0], 2) + Math.Pow(nearbyTowns[i, 1], 2));
                if (nearbyTownsOrderedByDistance.ContainsKey(currentRadius))
                {
                    nearbyTownsOrderedByDistance[currentRadius] += nearbyTowns[i, 2];
                }
                else
                {
                    nearbyTownsOrderedByDistance.Add(currentRadius, nearbyTowns[i, 2]);
                }
            }

            const int requiredPopulation = 1000000;
            int currentPopulation = tomskPopulation;

            foreach (var radiusCandidate in nearbyTownsOrderedByDistance)
            {
                var currentRadius = radiusCandidate.Key;
                currentPopulation += radiusCandidate.Value;

                if (currentPopulation >= requiredPopulation)
                {
                    return currentRadius;
                }
            }

            return -1; // No required towns nearby
        }

        private static void Main()
        {
            var n_s = Console.ReadLine().Split(new[] { ' ' }).Select(str => int.Parse(str)).ToArray();
            var n = n_s[0];
            var s = n_s[1];

            var towns = new int[n, 3];
            for (int i = 0; i < n; i++)
            {
                var x_y_p = Console.ReadLine().Split(new[] { ' ' }).Select(str => int.Parse(str)).ToArray();
                towns[i, 0] = x_y_p[0];
                towns[i, 1] = x_y_p[1];
                towns[i, 2] = x_y_p[2];
            }

            var radius = CalculateMinimumRadiusToExpandForBecomingMegaCity(s, towns, n);

            Console.WriteLine(string.Format("{0:F6}", radius));

            Console.ReadLine();
        }
    }
}