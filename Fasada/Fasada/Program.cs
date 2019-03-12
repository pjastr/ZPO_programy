using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fasada
{
    class Program
    {
        // kod z książki: Daniel Krasnokucki, Wzorce projektowe. Leksykon kieszonkowy, Wyd. Helion 2017.

        static void Main(string[] args)
        {
            var obliczenia = new Fasada();
            double wynikDodawania = obliczenia.Dodaj(3.5673, 8.32);
            Console.WriteLine(wynikDodawania);
            double wynikOdejmowania = obliczenia.Odejmij(3.5673, 8.32);
            Console.WriteLine(wynikOdejmowania);
            var wynikAnd = obliczenia.And(1, 0);
            Console.WriteLine(wynikAnd);
            var wynikOr = obliczenia.Or(1, 0);
            Console.WriteLine(wynikOr);
            Console.ReadKey();
        }
    }

    class ObliczeniaMatematyczne
    {
        public double DodawanieLiczb(double a, double b)
        {
            return a + b;
        }
        public double OdejmowanieLiczb(double a, double b)
        {
            return a - b;
        }
    }

    class OperacjeBitowe
    {
        public int AND(int a, int b)
        {
            return a & b;
        }
        public int OR(int a, int b)
        {
            return a | b;
        }
    }

    class Fasada
    {
        ObliczeniaMatematyczne om = new ObliczeniaMatematyczne();
        OperacjeBitowe ob = new OperacjeBitowe();
        public double Dodaj(double a, double b)
        {
            return om.DodawanieLiczb(a, b);
        }
        public double Odejmij(double a, double b)
        {
            return om.OdejmowanieLiczb(a, b);
        }
        public int And(int a, int b)
        {
            return ob.AND(a, b);
        }
        public int Or(int a, int b)
        {
            return ob.OR(a, b);
        }
    }
}
