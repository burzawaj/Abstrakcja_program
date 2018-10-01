using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcja_program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Kwadrat mojKwadrat = new Kwadrat(5);
            Console.WriteLine("Obwod kwadratu: {0}",mojKwadrat.Obwod());//te formatowanie
            Console.WriteLine($"Pole kwadratu: {mojKwadrat.Pole()}"); //i te też są poprawne i mają jednakowy efekt 
            Console.WriteLine($"Przekatna kwadratu: {mojKwadrat.Przekatna()}");
            
            Kolo mojeKolo = new Kolo(3);
            Console.WriteLine("Obwod kola: {0}", mojeKolo.Obwod());//te formatowanie
            Console.WriteLine($"Pole kwadratu: {mojeKolo.Pole()}"); //i te też są poprawne i mają jednakowy efekt */

            /*Trojkat mojTrojkat = new Trojkat(3, 4);
            Console.WriteLine($"Przeciwprostokatna trojkata: {mojTrojkat.Przeciwprastokatna}");
            Console.WriteLine("Obwod trojkata: {0}", mojTrojkat.Obwod());
            Console.WriteLine($"Pole trojkata: {mojTrojkat.Pole()}"); */
            
            Figura[] figury = new Figura[4];
            figury[0] = new Kwadrat(3);
            figury[1] = new Kolo(3);
            figury[2] = new Prostokat(4,3);
            figury[3] = new Trojkat(3,4);

            foreach (Figura figura in figury)
            {
                Console.WriteLine($"Pole figury: {figura.Pole()}");
                Console.WriteLine($"Obwod figury: {figura.Obwod()}");

            }
            //


            Console.ReadLine();
        }
    }
}
