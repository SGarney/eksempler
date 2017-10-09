﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] Funktioner = new IDbFunktioner[4];
            Funktioner[0] = new Hund();
            Funktioner[1] = new Ubåd();
            Funktioner[2] = new Ubåd();
            Funktioner[3] = new Hund();

            foreach (var item in Funktioner)
            {
                item.Gem();
            }
        }
        interface IDbFunktioner
        {
            void Gem();
        }
        class Hund : IDbFunktioner
        {
            public string Navn { get; set; }

            public void Gem()
            {
                Console.WriteLine("Gemmer hund");
            }
        }
        class Ubåd : IDbFunktioner
        {
            public int Nummer { get; set; }
            public double Turbine { get; set; }

            public void Gem()
            {
                Console.WriteLine("Gemmer ubåd");
            }
        }
    }
}
