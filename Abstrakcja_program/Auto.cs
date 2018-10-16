using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcja_program
{
    class Auto:Pojazd
    {
        public int AktualnyBieg { get; set; }
        public override void WyswietlKolor()
        {
            Console.WriteLine("Jestem samochodem");
            base.WyswietlKolor();
            Console.WriteLine($"Aktualny bieg: {AktualnyBieg}");
        }
    }
}
