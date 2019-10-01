using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18
{
    class Program
    {
        /*
         *  Write a C# Sharp program to check the largest number among three given integers.
         */
        static void Main(string[] args)
        {
            Console.WriteLine(test(1, 3, 2));
            Console.ReadKey();
        }

        public static int test(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b,c));
        }
    }
}
