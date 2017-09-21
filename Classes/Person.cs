using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }

        public Person(string Fornavn,string Efternavn,int Fødselsår)
        {
            this.Fornavn = Fornavn.ToUpper();
            this.Efternavn = Efternavn.ToUpper();
            this.Fødselsår = Fødselsår;

        }

        public string FuldtNavn()
        {
            //string Navn = this.Fornavn + " " + this.Efternavn;
            //return Navn;
            return $"{Fornavn} {Efternavn}";
        }

        public int Alder()
        {
            DateTime dato = DateTime.Now;
            int Alder = dato.Year - Fødselsår;
            return Alder;
        }
    }
}
