using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class UdvidetRandom : System.Random
    {
        private static Random rnd = new Random();
        public bool NextBool()
        {
            return this.Next(1,1002) > 500;
        }
    }
}
