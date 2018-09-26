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

        public Kolo(double radius)
        {
            Radius = radius;
        }

        public override double Obwod()
        {
            return 2*Math.PI*Radius;
        }

        public override double Pole()
        {
            return Math.PI * Radius*Radius;
        }
    }
}
