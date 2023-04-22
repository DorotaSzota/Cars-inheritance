using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    abstract class Samochod
    {
        public static string kolor { get; set; }
        public static string marka { get; set; }    
        public static double rozmiarSilnika { get; set; }

        public Samochod(string k, string m, double rs)
        {
            kolor = k;
            marka = m;
            rozmiarSilnika = rs;
        }
        public abstract void Kolor();
        public abstract void Marka();
        public virtual void RozmiarSilnika() 
        { }
    }
}
