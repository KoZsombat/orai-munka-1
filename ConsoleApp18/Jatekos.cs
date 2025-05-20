using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Jatekos : Karakter
    {
        public int Tapasztalat { get; set; }

        public Jatekos(string nev, int elet, int sebzes, int tapasztalat) : base(nev, elet, sebzes)
        {
            this.Tapasztalat = tapasztalat;
        }

        public override void Tamad()
        {
            Console.WriteLine($"{Nev} karddal támad! Sebzés: {Sebzes} Tapasztalat: {Tapasztalat}");
        }
    }
}
