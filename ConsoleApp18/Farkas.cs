using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Farkas : Karakter
    {
        public bool Szeliditett { get; set; }

        public Farkas(string nev, int elet, int sebzes, bool szeliditett) : base(nev, elet, sebzes)
        {
            this.Szeliditett = szeliditett;
        }

        public override void Tamad()
        {
            if (Szeliditett)
                Console.WriteLine($"{Nev} segít a játékosnak támadni!");
            else
                Console.WriteLine($"{Nev} harap! Sebzés: {Sebzes}");
        }
    }
}
