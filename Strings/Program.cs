using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletNavn = fornavn + " " + efternavn;
            string navnStort = samletNavn.ToUpper();
            string navnLille = samletNavn.ToLower();
            string del = samletNavn.Substring(7, 4);

            string[] a = samletNavn.Split(' ');

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("TEST1\tTEST1");
            Console.WriteLine();
            Console.WriteLine("TEST2\nTEST2");
            Console.WriteLine();
            Console.WriteLine("TEST3\r\nTEST3");

            System.IO.File.WriteAllText("C:\\temp\\test.txt",samletNavn);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
