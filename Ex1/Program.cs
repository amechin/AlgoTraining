using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(sum(1, 2));
            Console.WriteLine(diff51(56));
            Console.ReadKey();
        }

        // Exercice 1
        public static int sum(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }

        /* Exercice 2
         * Write a C# Sharp program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference
         */
        public static int diff51(int n)
        {
            return n > 51 ? (n - 51) * 3 : 51 - n;
        }


    }
}
