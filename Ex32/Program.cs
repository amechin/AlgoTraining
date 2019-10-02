using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex32
{
    class Program
    {
        /*
         * Write a C# Sharp program to check a specified number is present in a given array of integers.
         */
        static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 2, 3, 4 }, 0));
            Console.WriteLine(test(new[] { 1, 2, 3, 4 }, 1));
            Console.WriteLine(test(new[] { 1, 2, 3, 4 }, 4));
            Console.ReadKey();
        }
        public static bool test(int[] tab, int x)
        {
            return tab.Length == 4 ? Array.Exists(tab, element => element == x) : false;
        }
    }
}
