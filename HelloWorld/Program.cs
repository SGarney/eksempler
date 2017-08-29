using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Indtast navn");

            string input = Console.ReadLine();

            input = input.ToUpper();

            Console.WriteLine("Velkommen " + input);

            System.Console.Write("Tryk en tast for at fortsætte");

            System.Console.ReadKey();

        }
    }
}
