using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Vare
    {
        private string navn;
        private double pris;

        public string Navn
        {
            get {
                Console.WriteLine("Get navn: " + navn);
                return navn;
            }
            set {
                Console.WriteLine("Set navn: " + navn);
                navn = value;
            }
        }

        public double Pris
        {
            get {
                Console.WriteLine("Get pris: " + this.pris);
                return pris;
            }
            set {
                Console.WriteLine("Set pris: " + value);
                pris = value;
            }
        }

        public Vare() : this("",0.0)
        {

        }
        public Vare(string navn, double pris)
        {
            this.Navn = navn;
            this.Pris = pris;
        }

        public double PrisMedMoms()
        {
            double prisMedMoms = this.Pris + 0.1 * this.Pris;
            return prisMedMoms;
        }
    }
}
