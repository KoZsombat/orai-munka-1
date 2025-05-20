using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Karakter
    {
        public string Nev { get; set; }
        public int Elet { get; set; }

        public int Sebzes { get; set; }

        public Karakter(string nev, int elet, int sebzes)
        {
            this.Nev = nev;
            this.Elet = elet;
            Sebzes = sebzes;
        }

        public virtual void Tamad()
        {
            Console.WriteLine($"{Nev} támad! Sebzés: {Sebzes}");
        }

        public void Harcol(Karakter ellenfel)
        {
            Console.WriteLine($"{Nev} harcol vele: {ellenfel.Nev}!");
            while (Elet > 0 || ellenfel.Elet > 0)
            {
                Elet -= ellenfel.Sebzes;
                ellenfel.Elet -= Sebzes;
            }
            if (Elet < 0)
                Console.WriteLine($"{ellenfel.Nev} nyert!");
            else
                Console.WriteLine($"{Nev} nyert!");
        }
    }
}
