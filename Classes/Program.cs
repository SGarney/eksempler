using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Terning t2 = new Terning(true);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();

            Person m1 = new Person();
            m1.Fornavn = "Carl";
            m1.Efternavn = "Cooper";
            m1.Fødselsår = 1970;
            Console.WriteLine(m1.FuldtNavn());
            Console.WriteLine(m1.Alder()+" years old");

            Person m2 = new Person("Judy", "Thomas", 1964);
            Console.WriteLine(m2.FuldtNavn());
            Console.WriteLine(m2.Alder() + " years old");
        }
    }
}
