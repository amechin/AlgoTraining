using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(1, 2));
            Console.ReadKey();
        }

        public static int test(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
    }
}
