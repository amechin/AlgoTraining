using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        /*
         * Write a C# Sharp program to exchange the first and last characters in a given string and return the new string
         */
        static void Main(string[] args)
        {
            string input = "Marie";
            Console.WriteLine(test(input));
            Console.ReadKey();
        }

        public static string test(string str)
        {
            if (str.Length > 1)
            {
                char first = str[0];
                char last = str[str.Length - 1];
                str = str.Remove(0, 1);
                str = str.Remove(str.Length - 1, 1);
                str = last.ToString().ToUpper() + str + first.ToString().ToLower();
            }
            return str;
        }
    }
}
