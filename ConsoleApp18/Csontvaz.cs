using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Csontvaz : Karakter
    {
        public Csontvaz(string nev, int elet, int sebzes) : base(nev, elet, sebzes)
        {

        }

        public override void Tamad()
        {
            Console.WriteLine($"{Nev} íjjal támad! Sebzés: {Sebzes}");
        }
    }
}
