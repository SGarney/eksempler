using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Terning
    {
        private int værdi;
        private static Random rnd = new Random();

        public int Værdi
        {
            get {
                Console.WriteLine("Terning værdi hentet");
                return værdi;
            }
            set {
                Console.WriteLine("Terning værdi sat");
                if (value < 1 || value > 6)
                    værdi = 1;
                else
                    værdi = value;
            }
        }

        public Terning()
        {
            this.Ryst();
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
        }
    }
}
