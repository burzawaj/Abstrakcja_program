using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcja_program
{
    abstract class Figura
    {
        public abstract double Pole();
        public abstract double Obwod();
        public abstract void WyswietlKolor();
        public enum KolorFigury
        {
            Bialy,
            Czarny,
            Zielony,
            Niebieski,
            Czerwony,
            Zolty,

        }
    }
}
