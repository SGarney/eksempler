using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Dyr[] DyreArray = new Dyr[20];
            for (int i = 0; i < 20; i++)
            {
                DyreArray[i] = Dyr.TilfældigtDyr();
            }
            foreach (var item in DyreArray)
            {
                item.SigNoget();
            }

            //Dyr D = new Dyr();
            //D.Navn = "KERBUNCKLE";
            //D.SigNoget();
        }
    }
}
