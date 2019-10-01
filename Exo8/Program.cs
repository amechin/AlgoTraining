using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        /*
         * Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string. If the given string length is less than 2 return the original string
         */
        static void Main(string[] args)
        {
            var ans = Console.ReadLine().ToString();
            Console.WriteLine(test(ans));
            Console.ReadKey();
        }

        public static string test(string str)
        {
            return str.Length > 1 ? str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) : str;
        }
    }
}
