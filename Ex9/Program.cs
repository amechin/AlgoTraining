using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        /*
         *  Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of length 1 or more
         */
        static void Main(string[] args)
        {
            string input = "Adrien";
            Console.WriteLine(test(input));
            Console.ReadLine(); 
        }
        
        public static string test(string str)
        {
            return str.Substring(str.Length - 1) + str + str.Substring(str.Length - 1);
        }
    }
}
