using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            t.Skriv();
            LudoTerning lt = new LudoTerning(5);
            lt.Skriv();
            Console.WriteLine("Globus?: "+lt.ErGlobus());
            Console.WriteLine("Stjerne?: "+lt.ErStjerne());
        }
    }
}
