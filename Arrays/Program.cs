using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10000, 20000, 15000, 20000, 30000, 15000 };
            decimal sumA = 0;
            decimal gennemsnit;

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
                sumA += a[i];
            }

            gennemsnit = sumA / a.Length;
            Console.WriteLine("Gennemsnit " + gennemsnit.ToString("N2"));

            var ave2 = a.Average();
            Console.WriteLine("Average using Average() function: " + ave2.ToString("N2"));
            Console.WriteLine(a.Average());

            Array.Sort(a);

            Console.WriteLine();
            Console.WriteLine("Sorted array: ");

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine();
            string res = string.Join(",", a);
            Console.WriteLine("Joinging array values as strings:\n" + res);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
