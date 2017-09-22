using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    abstract class Dyr
    {
        public string Navn { get; set; }
        private static Random rnd = new Random();
        public abstract void SigNoget();
        //{
        //    Console.WriteLine("Jeg er et dyr og hedder " + this.Navn);
        //}

        public static Dyr TilfældigtDyr()
        {
            string sti = @"X:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);
            //for (int i = 0; i < navne.Length; i++)
            //{
            //    Console.WriteLine(navne[i]);
            //}
            int num = rnd.Next(0, navne.Length);
            if (num % 2 == 0)
            {
                return new Hund() { Navn = navne[num] };
            }
            else
            {
                return new Kat() { Navn = navne[num] };
            }
        } 
    }
}
