using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06
{
    class Program
    {
        static void Main(string[] args)
        {
            Person i = null;
            Console.WriteLine(i);
            i = new Person();
            Console.WriteLine(i);

            Person u = new Person(); // objekt paa stack bundet sammen med (=) objekt paa heap

            u = null; // slet reference til heap (objektet paa heap bliver slettet)
            u = i; // u peger paa samme objekt paa heap som i

            Person w;

            i.navn = "Mikkel";
            i.alder = 14;
            i.erILive = true;

            Person ii = new Person("Lene",48, true);
            ii.navn = "Lene";

            ii = null;
            ii = i;
            Console.WriteLine(i.navn);
            Console.WriteLine(ii.navn);
            w = u;
            Console.WriteLine(w.navn);
            w = null;
            //Console.WriteLine(w.navn); gives error

            Console.WriteLine();
            Console.WriteLine();

            Terning t1 = new Terning();
            t1.Skriv();
            Terning t2 = new Terning(6);
            t2.Skriv();
            Terning t3 = new Terning(60);
            t3.Skriv();
            //t3.vaerdi = 6; beskyttet ved at gøre den private
            t3.Skriv();
            Console.WriteLine("Værdien er " + t3.HentVaerdi());
            t3.GemVaerdi(6);
            t3.Skriv();
            t3.GemVaerdi(600);
            t3.Skriv();

        }
    }
}
