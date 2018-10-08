using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcja_program
{
    class Kolo : Figura
    {
        public double Radius { get; set; }
        public int XKola { get; private set; }
        public int YKola { get; private set; }


        public Kolo(double radius, Punkt SrodekOkregu)
        {
            Radius = radius;
            XKola = SrodekOkregu.X;
            YKola = SrodekOkregu.Y;
        }
        public KolorFigury kolorKola = KolorFigury.Czerwony;

        public override double Obwod()
        {
            return 2*Math.PI*Radius;
        }

        public override double Pole()
        {
            return Math.PI * Radius*Radius;
        }
        public override void WyswietlKolor()
        {
            Console.WriteLine("Kolor kola jest {0}", kolorKola);
        }
    }
}
