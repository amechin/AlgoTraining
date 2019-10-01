    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        /*
         * Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.
         */

        static void Main(string[] args)
        {
            Console.WriteLine(test(30, 15));
            Console.WriteLine(test(15, 30));
            Console.WriteLine(test(15, 15));
            Console.WriteLine(test(14, 18));
            Console.ReadKey();
        }

        public static bool test(int x, int y)
        {
            if(x == 30 || y == 30 || (x + y) == 30)
            {
                return true;
            }else
            {
                return false;
            }



        }
    }
}
