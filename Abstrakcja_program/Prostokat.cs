﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcja_program
{
    class Prostokat : Kwadrat
    {
        public double Bok2 { get; private set; }
        public int XProstokata { get; private set; }
        public int YProstokata { get; private set; }
        public Prostokat(double bok, double bok2, Punkt punktPoczatkowy) : base(bok, punktPoczatkowy)
        {
            Bok2 = bok2;
            XProstokata = punktPoczatkowy.X;
            YProstokata = punktPoczatkowy.Y;
        }
        public KolorFigury kolorProstokata = KolorFigury.Czerwony;
        public override double Pole()
        {
            return Bok * Bok2;
        }
        public override double Obwod()
        {
            return 2*Bok + 2*Bok2;
        }
        public override double Przekatna()
        {
            return Math.Sqrt(Math.Pow(Bok, 2) + Math.Pow(Bok2, 2));
        }
        public override void WyswietlKolor()
        {
            Console.WriteLine("Kolor prostokata jest {0}", kolorProstokata);
        }
    }
}
