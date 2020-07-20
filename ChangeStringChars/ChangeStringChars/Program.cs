using System;
using System.Collections.Generic;

namespace ChangeStringChars
{
    class Program
    {

        public static void Main()
        {
            var r = new List<int>() { 1,5,2,77};
            r.Sort();
            var d = r; 
            char[] s = Console.ReadLine().ToCharArray();

            int index = 0;
            while (s[index] == 'a' && index + 1 < s.Length)
            {
                index++;
            }

            do
            {
                s[index] = (char)('a' + (s[index] - 'a' + 25) % 26);
                index++;
            } while (index < s.Length && s[index] != 'a');

            Console.WriteLine(new string(s));
            Console.ReadLine();
        }

        //static void Main(string[] args)
        //{
        //    var s = (string)Console.ReadLine();
        //    var d = GetString(s);
        //    Console.WriteLine(d);
        //    Console.ReadLine();
        //}

        //public static string ReplaceByIndex(string text, int start, char replacement)
        //{
        //    return text.Substring(0, start) + replacement
        //         + text.Substring(start + 1);
        //}

        //public static string GetString(string s)
        //{
        //    int k = 0;
        //    for (int j = 0; j < s.Length; j++)
        //    {
        //        k = j;
        //        if (s[j] != 'a')
        //        {
        //            break;
        //        }
        //    }

        //    if (k == s.Length - 1)
        //    {
        //        s = ReplaceByIndex(s, k, 'z');
        //        return s;
        //    }


        //    for (int i = k; i < s.Length; i++)
        //    {
        //        if (s[i] != 'a')
        //        {
        //            s = ReplaceByIndex(s, i, (char)(s[i] - 1));
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }

        //    return s;
        //}
    }
}
