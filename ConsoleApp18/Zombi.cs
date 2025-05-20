using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Zombi : Karakter
    {
        public Zombi(string nev, int elet, int sebzes) : base(nev, elet, sebzes)
        {

        }

        public override void Tamad()
        {
            Console.WriteLine($"{Nev} hörögve támad! Sebzés: {Sebzes}");
        }
    }
}
