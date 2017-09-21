using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //*****Vare*****
            Vare v1 = new Vare();
            v1.Navn = "mælk";
            v1.Pris = 9.95;
            Console.WriteLine("Nyt Navn: "+v1.Navn +" Ny Pris: "+v1.Pris);
            Console.WriteLine("Pris med moms: "+ v1.PrisMedMoms());
            Vare v2 = new Vare("æg", 15.5);
            Console.WriteLine("Nyt Navn: " + v2.Navn + " Ny Pris: " + v2.Pris);
            Console.WriteLine("Pris med moms: " + v2.PrisMedMoms());
            //*****Vare*****

            //*****Terning*****
            Terning t1 = new Terning();
            t1.Værdi = 5;
            Console.WriteLine(t1.Værdi);
            t1.Ryst();
            Console.WriteLine(t1.Værdi);
            t1.Skriv();
            Terning t2 = new Terning(2);
            t1.Værdi = 4;
            Console.WriteLine(t1.Værdi);
            //*****Terning*****
        }
    }
}
