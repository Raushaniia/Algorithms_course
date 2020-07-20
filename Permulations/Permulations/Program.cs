using System;
using System.Collections.Generic;

namespace Permulations
{
    public class Program
    {
        public static List<int> fullarray = new List<int>();

        public static List<string>  resultList = new List<string>();

        static void Main(string[] args)
        {
            string g = (Console.ReadLine());
            var number = Int32.Parse(g);

            for (int s = 1; s <= number; s++)
            {
                fullarray.Add(s);
            }

            var currentNumber = String.Empty;
            GetPermulations(currentNumber, fullarray);
            foreach (var t in resultList)
            {
                Console.WriteLine(t);
            }

            Console.ReadLine();
        }

        public static string GetPermulations(string currentNumber, List<int> leftArray)
        {
            if (leftArray.Count == 1)
            {
                var res = String.Concat(currentNumber, leftArray[0]);
                resultList.Add(res);
                return currentNumber;
            }
            var leftArrayCopy = new List<int>();
            for (int i = 0; i < leftArray.Count; i++)
            {
                var temp = String.Concat(currentNumber, leftArray[i]);
                leftArrayCopy = new List<int>(leftArray);
                leftArrayCopy.RemoveAt(i);
                temp = GetPermulations(temp + " ", leftArrayCopy);
            }

            return null;
        }
    }
}
