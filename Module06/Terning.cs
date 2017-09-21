using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06
{
    public class Terning
    {
        private int vaerdi;

        public Terning() : this(4)
        {
            //this.vaerdi = 1;
        }

        public Terning(int startVaerdi)
        {
            if (startVaerdi < 1 || startVaerdi > 6)
                startVaerdi = 4;

            this.vaerdi = startVaerdi; //her er this ikke nødvendigt
        }


        /// <summary>
        /// Skriver terningen ud til consol
        /// </summary>
        public void Skriv()
        {
            Console.WriteLine("["+this.vaerdi+"]");
            Console.ReadKey();
        }

        public int HentVaerdi() // getter
        {
            //log
            //sikkerhed
            return this.vaerdi;
        }

        public void GemVaerdi(int vaerdi) // setter
        {
            //log
            //sikkerhed
            //validering
            if (vaerdi < 1 || vaerdi > 6)
                vaerdi = 4;
            this.vaerdi = vaerdi;
        }
    }
}
