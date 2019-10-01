using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30
{
    class Program
    {
        /*
         * Write a C# Sharp program to create a string like "aababcabcd" from a given string "abcd"
         */
        static void Main(string[] args)
        {
            Console.WriteLine(test("Abracadabra"));
            Console.ReadKey();
        }

        static string test(string str)
        {
            string ans = "";
            for(int i=0; i<str.Length; i++)
            {
                for (int j=0; j<=i; j++)
                {
                    ans += str[j];
                }
            }
            return ans;
        }
    }
}
