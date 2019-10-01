using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31
{
    class Program
    {
        /*
         * Write a C# Sharp program to count a substring of length 2 appears in a given string and also as the last 2 characters of the string. Do not count the end substring.
         */

        static void Main(string[] args)
        {
            Console.WriteLine(Test("Marie"));
            Console.ReadLine();
        }

        static int Test(string str)
        {
            return str.Length % 2 == 0 ? str.Length / 2 : (str.Length - 1) / 2;
        }

    }
}
