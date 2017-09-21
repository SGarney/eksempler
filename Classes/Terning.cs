using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Terning
    {
        public int værdi;
        private bool snyd;
        private static Random rnd = new Random();

        public Terning()
        {
            this.værdi = 1;
            this.snyd = false;
        }

        public Terning(bool snyd)
        {
            this.værdi = 1;
            this.snyd = snyd;
        }
        public void Skriv()
        {
            Console.WriteLine("[" + this.værdi + "]");
        }

        public void Ryst()
        {
            if (snyd == false)
            {
                this.værdi = rnd.Next(1, 7);
            }
            else
            {
                this.værdi = 6;
            }
        }
    }
}
