using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartDag3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] V = new int[10]; Old way
            int[] V = { 5, 1, 7, 12, 1, 5 };
            int test = 10;
            ArrayResultat R = BeregnArray(V, ref test);

            Console.WriteLine(R.Sum);
            Console.WriteLine(R.Gennemsnit.ToString("N2"));
            Console.ReadKey();
        }

        static ArrayResultat BeregnArray(int[] vaerdier, ref int y) {

            ArrayResultat resultat;
            resultat.Sum = 0;
            resultat.Gennemsnit = 0;
            y = 100000;

            for (int i = 0; i < vaerdier.Length; i++)
            {
                resultat.Sum += vaerdier[i];
            }

            resultat.Gennemsnit = resultat.Sum / vaerdier.Length;

            vaerdier[0] = 10100;

            return resultat;
        }
    }
}
