using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcja_program
{
    class Samolot:Pojazd
    {
        public int Wysokosc { get; set; }
        public override void WyswietlKolor()
        {
            Console.WriteLine("Jestem samolotem");
            base.WyswietlKolor();
            Console.WriteLine($"Aktualna wysokość: {Wysokosc}");
        }
    }
}
