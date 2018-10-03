using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcja_program
{
    class Punkt
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Punkt(int _wspx, int _wspY)
        {
            X = _wspx;
            Y = _wspY;

        }
    }
}
