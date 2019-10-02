using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex34
{
    class Program
    {
        /*
         * Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere
         */
        static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 2, 6, 7, 1, 2, 3, 0, 9 }));
            Console.ReadKey();
        }

        public static bool test(int[] tab)
        {
            var ans = false;
            for(int i=0; i<tab.Length; i++)
            {
                if(tab[i]==1 && tab[i+1] == 2 && tab[i+2] == 3)
                {
                    ans = true;
                }
            }
            return ans;
        }
    }
}
