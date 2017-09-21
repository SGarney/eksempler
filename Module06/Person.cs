using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06
{
    internal class Person //internal class is default
    {
        public string navn; // private is default
        public int alder;
        public bool erILive;

        // default constructor (ctor \tab \tab)
        public Person() : this("", 0, true)
        {
            // initialisering
            //alder = -10;
            //navn = "";
            //erILive = true;
        }

        public Person(string navn, int alder, bool erILive)
        {
            // this
            if (alder < 0 || alder > 100)
                this.alder = 0;
            else
                this.alder = alder;
            this.navn = navn;
            this.erILive = erILive;


        }
    }
}
