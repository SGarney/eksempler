using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {

            int heltal = 10;
            Console.WriteLine(heltal);
            heltal++;
            Console.WriteLine(heltal);
            heltal--;
            Console.WriteLine(heltal);
            heltal += 20;
            Console.WriteLine(heltal);

            double kommatal = 12.5;
            Console.WriteLine(kommatal);
            kommatal++;
            Console.WriteLine(kommatal);
            kommatal--;
            Console.WriteLine(kommatal);
            kommatal *= 2;
            Console.WriteLine(kommatal);

            FilTyper nyfil = FilTyper.csv;
            Console.WriteLine(nyfil);
            Console.WriteLine((int)nyfil);

            DateTime dato = DateTime.Now;
            Console.WriteLine(dato.ToString("dd MMMM yyyy"));
            Console.WriteLine(dato.ToString("d M y m h"));
            Console.WriteLine(dato.ToLongDateString());

            Person p = new Person();
            p.Id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }

    enum FilTyper
    {
        csv,
        pdf,
        txt
    }
    struct Person
    {
        public int Id;
        public string Navn;
    }

}
