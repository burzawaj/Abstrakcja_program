using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcja_program
{
    abstract class Figura : IDrukowalny, IComparable<Figura>
    {
        public abstract double Pole();
        public abstract double Obwod();
        public abstract void WyswietlKolor();

        public int CompareTo(Figura other)
        {
            if (Pole()==other.Pole())
            {
                return 0;
            }
            else if (Pole() > other.Pole())
            {
                return 1;
            }
            return -1;
            
        }

        public void Wyswietl()
        {
            Console.WriteLine($"Pole figury {Pole()}");
            Console.WriteLine($"Obwód figury {Obwod()}");
        }

        public enum KolorFigury
        {
            Bialy,
            Czarny,
            Zielony,
            Niebieski,
            Czerwony,
            Zolty,

        }

        //public KolorFigury KolorTejFigury { get;set; }
    }
}
