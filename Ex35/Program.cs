using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex35
{
    class Program
    {
        /*
         * Write a C# Sharp program to compare two given strings and return the number of the positions where they contain the same length 2 substring
         */
        static void Main(string[] args)
        {
            Console.WriteLine(test("abcdefgh", "abijskab"));
            Console.ReadKey();
        }

        public static int test(string a, string b)
        {
            int counter = 0;
            for (int i = 0; i < a.Length-1; i++)
            {
                var sStr1 = a.Substring(i, 2);
                for (int j = 0; j < b.Length - 1; j++)
                {
                    var sStr2 = b.Substring(j, 2);
                    if (sStr1 == sStr2)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}
