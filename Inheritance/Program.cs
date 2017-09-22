using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person() {Fornavn = "Tom", Efternavn = "Potter"};
            Console.WriteLine(p1.FuldtNavn());

            Elev e1 = new Elev() { Fornavn = "Holly", Efternavn = "Johnson" , Klasselokale = "Rum1"};
            Console.WriteLine(e1.FuldtNavn());

            Instruktør i1 = new Instruktør() { Fornavn = "Timo", Efternavn = "Mayer", NøgleId = 345 };
            Console.WriteLine(i1.FuldtNavn());

            UdvidetRandom R = new UdvidetRandom();
            Console.WriteLine(R.NextBool());
        }
    }

}
