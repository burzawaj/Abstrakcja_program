﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcja_program
{
    class Kwadrat : Figura
    {
        double dlugoscBoku = 0;
        public int XKwadratu { get; private set; }
        public int YKwadratu { get; private set; }

        public Kwadrat(double bok, Punkt punktPoczatkowy)
        {
            dlugoscBoku = bok;
            XKwadratu = punktPoczatkowy.X;
            YKwadratu = punktPoczatkowy.Y;
        }
        public KolorFigury kolorKwadratu = KolorFigury.Czerwony;

        public double Bok { get { return dlugoscBoku; } }


        public override double Obwod()
        {
            return 4*Bok;
        }

        public override double Pole()
        {
            return Bok*Bok; //Math.Pow(Bok,2) to jest zapis potęgi wykorzystujący wbudowaną klasę Math
        }
        public virtual double Przekatna()
        {
            return Math.Sqrt(Math.Pow(Bok, 2)+ Math.Pow(Bok, 2));
        }
        public override void WyswietlKolor()
        {
            Console.WriteLine("Kolor kwadratu jest {0}", kolorKwadratu);
        }
    }
}
