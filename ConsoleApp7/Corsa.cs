using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Corsa:Samochod
    {
        private string kolorC;
        private string markaC = "Opel";
        private double pojemnoscSilC;

        public Corsa(string kolorC, double pojemnoscSilC) : base (kolorC, marka, pojemnoscSilC)
        {
            this.kolorC = kolorC;
            this.pojemnoscSilC = pojemnoscSilC;
            
        }
        override public void Kolor()
        {
            Console.WriteLine($"Kolor tego auta to {this.kolorC}.");
        }
         override public void Marka()
        {
            Console.WriteLine($"Marka to {this.markaC}.");
        }

        public override void RozmiarSilnika()

        { Console.WriteLine($"Pojemność silnika wynosi {this.pojemnoscSilC}.\n"); }

    }
}
