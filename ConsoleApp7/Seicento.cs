using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Seicento : Samochod
    {
		private string kolorS;
		private string markaS = "Fiat";
		private double pojemnoscSilS;

        public Seicento(string kolorS, double pojemnoscSilS) : base( kolorS, marka, pojemnoscSilS)
        {
			this.kolorS = kolorS;
			this.pojemnoscSilS = pojemnoscSilS;            
        }

        override public void Kolor( )
		{
            Console.WriteLine($"Kolor tego auta to {this.kolorS}.");
        }
        override public void Marka()
		{
            Console.WriteLine($"Marka to {this.markaS}.");
        }

		public override void RozmiarSilnika()

		{ Console.WriteLine($"Pojemność silnika wynosi {this.pojemnoscSilS}.\n"); }
    }
}
