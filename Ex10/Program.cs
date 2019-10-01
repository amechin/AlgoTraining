using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        /*
         * Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7
         */
        static void Main(string[] args)
        {
            int nb = 8;
            Console.WriteLine(test(nb));
            Console.ReadKey();
        }

        public static bool test(int nb)
        {
            return nb % 3 == 0 || nb % 7 == 0 ? true : false;
        }
    }
}
