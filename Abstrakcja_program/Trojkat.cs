using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcja_program
{
    class Trojkat : Figura
    {   
        public double Przyprostokatna1 { get; private set; }
        public double Przyprostokatna2 { get; private set; }
        public double Przeciwprastokatna { get; private set; }
        public int XTrojkata { get; private set; }
        public int YTrojkata { get; private set; }


        public Trojkat(double przyprostokatna1, double przyprostokatna2, Punkt punktPoczatkowy)
        {
            Przyprostokatna1 = przyprostokatna1;
            Przyprostokatna2 = przyprostokatna2;
            Przeciwprastokatna = Math.Sqrt(Math.Pow(Przyprostokatna1, 2) + Math.Pow(Przyprostokatna2, 2));
            XTrojkata = punktPoczatkowy.X;
            YTrojkata = punktPoczatkowy.Y;
            
        }

        public KolorFigury kolorTrojkata = KolorFigury.Czerwony;

        public override double Obwod()
        {
            return Przyprostokatna1+Przyprostokatna2+Przeciwprastokatna;
        }
        public override double Pole()
        {
            return (Przyprostokatna1*Przyprostokatna2)/2;
        }
        public override void WyswietlKolor()
        {
            Console.WriteLine("Kolor trojkata jest {0}", kolorTrojkata);
        }

    }
}
