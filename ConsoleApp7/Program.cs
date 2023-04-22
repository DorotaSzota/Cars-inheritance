namespace ConsoleApp7
{
    internal class Program
    {
        public static List <Samochod> samochods = new List <Samochod> ();
        static void Main(string[] args)
        {
            samochods.Add (new Seicento ("czerwony", 1.1));
            samochods.Add(new Corsa("biały", 1.4));

            foreach (Samochod s in samochods) 
            {
                s.Kolor();
                s.Marka();
                s.RozmiarSilnika();
            }
            
        }
    }
}