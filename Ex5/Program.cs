using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        /*
         * Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. If the string already begins with 'if', return the string unchanged
         */
      
        static void Main(string[] args)
        {
            string avec = "if OneTwoThree";
            string sans = "OneTwoThree";
            Console.WriteLine(test(avec));
            Console.WriteLine(test(sans));
            Console.ReadLine();
        }

        public static string test(string str)
        {
            //if (str.Substring(0, 2) != "if")
            //{
            //    str = "if " + str;
            //}
            //return str;

            return str.Substring(0, 2) != "if" ? "if " + str : str;
        }



    }
}
