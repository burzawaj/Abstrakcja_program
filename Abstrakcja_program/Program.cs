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
            TestSlownik();
            return; //nie wykona dalszej częsci kodu
            TestFigure();
            return; //nie wykona dalszej częsci kodu
            TestList();
            return; //nie wykona dalszej częsci kodu
            /*Kwadrat mojKwadrat = new Kwadrat(5);
            Console.WriteLine("Obwod kwadratu: {0}",mojKwadrat.Obwod());//te formatowanie
            Console.WriteLine($"Pole kwadratu: {mojKwadrat.Pole()}"); //i te też są poprawne i mają jednakowy efekt 
            Console.WriteLine($"Przekatna kwadratu: {mojKwadrat.Przekatna()}");
            
            Kolo mojeKolo = new Kolo(3);
            Console.WriteLine("Obwod kola: {0}", mojeKolo.Obwod());//te formatowanie
            Console.WriteLine($"Pole kwadratu: {mojeKolo.Pole()}"); //i te też są poprawne i mają jednakowy efekt */

            Punkt PunktPoczatkowyTrojkat = new Punkt(1, 1);
            //Trojkat mojTrojkat = new Trojkat(3, 4, PunktPoczatkowyTrojkat);
            //Console.WriteLine($"Przeciwprostokatna trojkata: {mojTrojkat.Przeciwprastokatna}");
            //Console.WriteLine("Obwod trojkata: {0}", mojTrojkat.Obwod());
            //Console.WriteLine($"Pole trojkata: {mojTrojkat.Pole()}");
            //mojTrojkat.WyswietlKolor();
            //mojTrojkat.kolorTrojkata = Figura.KolorFigury.Zielony;
            //mojTrojkat.WyswietlKolor();

            Punkt PunktPoczatkowyKwadrat = new Punkt(15, 15);
            Punkt PunktPoczatkowyProstokat = new Punkt(30, 30);
            Punkt SrodekKola = new Punkt(45, 45);

            Figura[] figury = new Figura[4];
            figury[0] = new Kwadrat(3,PunktPoczatkowyKwadrat);
            figury[1] = new Kolo(3, SrodekKola);
            figury[2] = new Prostokat(4,3, PunktPoczatkowyProstokat);
            figury[3] = new Trojkat(3,4, PunktPoczatkowyTrojkat);

            foreach (Figura figura in figury)
            {
                Console.WriteLine($"Pole figury: {figura.Pole()}");
                Console.WriteLine($"Obwod figury: {figura.Obwod()}");
                figura.WyswietlKolor();
                
               

            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Trojkat mojTrojkat = new Trojkat(3, 4, PunktPoczatkowyTrojkat);
            Console.WriteLine($"Przeciwprostokatna trojkata: {mojTrojkat.Przeciwprastokatna}");
            Console.WriteLine("Obwod trojkata: {0}", mojTrojkat.Obwod());
            Console.WriteLine($"Pole trojkata: {mojTrojkat.Pole()}");
            mojTrojkat.WyswietlKolor();
            mojTrojkat.kolorTrojkata = Figura.KolorFigury.Zielony;
            mojTrojkat.WyswietlKolor();
            Kwadrat nastepnyKwadrat = new Kwadrat(2, PunktPoczatkowyKwadrat);
            Console.WriteLine($"Pole kwadratu: {nastepnyKwadrat.Pole()}");
            //nastepnyKwadrat.CompareTo(mojTrojkat);
            Console.WriteLine($"Porównanie pol: {nastepnyKwadrat.CompareTo(mojTrojkat)}");

            

            Console.ReadLine();
        }
        static void TestList()
        {
            //inicjalizacja listy
            List<string> names = new List<string>()
            {
                "Andrzej",
                "Wojtek",
                "Adam",
                "Paweł",
                "Jarek",


            };
            PrintList(names);
            names.Add("Piotr");//dodałem na koniec listy nowy element
            names.Insert(0,"Jan"); //dodałem na początek listy nowy element
            PrintList(names);
            Console.WriteLine(names.IndexOf("Jarek"));
            names.Remove("Adam");
            PrintList(names);
            Console.WriteLine(names.IndexOf("Jarek"));
            names.RemoveAt(names.Count()-1);
            PrintList(names);
            Console.WriteLine(names.IndexOf("Jarek"));
            Console.WriteLine($"czy moja lista zawiera imię Anastazy: {names.Contains("Anastazy")}");
            //PrintList(names.FindAll(LongerThen5)); //wyświetlam listę o ilości liter większej niż 5
            //PrintList(names.FindAll(LiczbaLiterNieparzysta));
            //names.RemoveAll(name => (name.Length % 2) != 0);//to jest równoznaczne z funkcja w poniższych dwóch linijkach tylko za pomocą "lambda expresion"
            //names.RemoveAll(LiczbaLiterNieparzysta);
            //PrintList(names);
            //names.Sort();
            //PrintList(names);
            names.Sort(CompareStringLength); //sortujemy wg długości wyrazów //poniżej rozwiązanie analogiczne przy wykorzystaniu lambda expresion 
            /*names.Sort((x, y) =>
            {
                int result = 0;
                if (x.Length > y.Length)
                {
                    result = 1;
                }
                else if (x.Length < y.Length)
                {
                    result = -1;
                }
                return result;
            }
            );*/
            PrintList(names);
            names.Clear();
            PrintList(names);
            Console.ReadLine();


        }
        //static void PrintList(IEnumerable<string> list) ten zapis i ten poniżej jest równozanczny ponieważ List należy do IEnumerable
        static void PrintList(List<string> list)
        {
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("Itme in list");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(Environment.NewLine);
            
        }
        static bool LongerThen5(string wyraz)
        {
            return wyraz.Length > 5;
        }
        static bool LiczbaLiterNieparzysta(string wyraz)
        {
            return wyraz.Length % 2 != 0;
        }
        static int CompareStringLength(string x, string y)//porównujemy dlugosć wyrazów
        {
            int result = 0;
            if (x.Length>y.Length)
            {
                result = 1;
            }
            else if (x.Length < y.Length)
            {
                result = -1;
            }
            return result;
        }
        static void TestFigure()
        {
            //inicjalizacja listy
            Punkt NowyPunkt1 = new Punkt(1, 1);
            List<Figura> ListaFigur = new List<Figura>()
            {
                new Kwadrat(5,NowyPunkt1),
                new Kwadrat(2,NowyPunkt1),
                new Kwadrat(3,NowyPunkt1),
                new Kolo(6,NowyPunkt1),
                new Kolo(4,NowyPunkt1),
            };

            ListaFigur.Sort();
            foreach (var item in ListaFigur)
            {
                //Console.WriteLine(item.Pole());
            }
            Console.ReadLine();
        }
        static void TestSlownik()
        {
            //inicjalizacja słownika
            Dictionary<int, string> slownik = new Dictionary<int, string>()
            {
                { 1,"jeden" },
                { 2,"dwa" },
                { 3,"trzy" },
                { 4,"cztery" },
                { 5, "pięć" },
            };
            Console.WriteLine($"Wpisałem {slownik.Count()} pozycji do słownika");
            Console.WriteLine($"Pod indeksem 3 jest {slownik[3]}");
            slownik.Add( 6,"sześć");
            Console.WriteLine($"Wpisałem {slownik.Count()} pozycji do słownika");
            Console.WriteLine($"Pod indeksem 6 jest {slownik[6]}");

            DodajElementDoSlownika(slownik,7, "siedem");
            Console.WriteLine($"Wpisałem {slownik.Count()} pozycji do słownika");
            Console.WriteLine($"Pod indeksem 7 jest {slownik[7]}");

            Console.ReadLine();
        }
        static void DodajElementDoSlownika(Dictionary<int,string> slownik, int klucz, string wartosc)
        {
            if (!slownik.ContainsKey(klucz))
            {
                slownik.Add(klucz, wartosc);
            }

        }



    }
}
