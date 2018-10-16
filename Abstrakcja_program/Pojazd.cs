using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcja_program
{
    abstract class Pojazd : IDrukowalny 
    {
        public int CurrentSpeed { get; private set; }

        
        public void SpeedUp(int speed)
        {
            CurrentSpeed = CurrentSpeed + speed;
        }

        public virtual void WyswietlKolor()
        {
            Console.WriteLine($"Aktualna predkosc: {CurrentSpeed}");
        }

    }
}
