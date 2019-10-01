using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        /*
         * Write a C# Sharp program to remove the character in a given position of a given string. The given position will be in the range 0.. string length -1 inclusive
         */
        static void Main(string[] args)
        {
            string input = "Marie";
            Console.WriteLine(remve(input, 5));
            Console.ReadLine();
        }

        public static string remve(string str, int p)
        {
            //int index = p - 1;
            //string ans = null;
            //if(index >= 0 && index < str.Length)
            //{
            //    for(int i = 0; i < str.Length; i++)
            //    {
            //        if(i != index)
            //        {
            //            ans += str[i].ToString();
            //        }
            //    }
            //}else
            //{
            //    ans = str;
            //}
            //return ans;

            return str.Remove(p, 1);

        }
    }
}
