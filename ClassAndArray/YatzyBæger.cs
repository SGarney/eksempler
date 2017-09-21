using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndArray
{
    class YatzyBæger
    {
        private Terning[] Terninger;

        public YatzyBæger()
        {
            Terninger = new Terning[5];
            for (int i = 0; i < 5; i++)
            {
                Terninger[i] = new Terning();
            }
        }

        public void Ryst()
        {
            foreach (var item in this.Terninger)
            {
                item.Ryst();
            }
        }

        public void Skriv()
        {
            foreach (var item in this.Terninger)
            {
                item.Skriv();
            }
            Console.WriteLine();
        }
    }
}
