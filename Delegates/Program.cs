using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = Beregner(2, 3, Plus);
            Console.WriteLine(res);
            res = Beregner(8, 5, Minus);
            Console.WriteLine(res);
            res = Beregner(10, 2, Divider);
            Console.WriteLine(res);
            res = Beregner(3, 3, Gange);
            Console.WriteLine(res);
        }

        public delegate int BeregnDelegate(int x, int y);

        public static int Beregner(int x, int y, BeregnDelegate funkt)
        {
            return funkt(x, y);
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Divider(int a, int b)
        {
            return a / b;
        }
        public static int Gange(int a, int b)
        {
            return a * b;
        }
    }
}
