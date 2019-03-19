using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    //kod z ksiazki: Daniel Krasnokucki, Wzorce projektowe. Leksykon kieszonkowy, Wyd. Helion 2017.

    class Program
    {
        static void Main(string[] args)
        {
            var kolekcja = new Kolekcja
            {
                [0] = new Litera("A"),
                [1] = new Litera("B"),
                [2] = new Litera("C"),
                [3] = new Litera("D"),
                [4] = new Litera("E"),
                [5] = new Litera("F"),
                [6] = new Litera("G"),
                [7] = new Litera("H"),
                [8] = new Litera("I"),
                [9] = new Litera("J"),
                [10] = new Litera("K"),
                [11] = new Litera("L"),
                [12] = new Litera("M"),
                [13] = new Litera("N"),
                [14] = new Litera("O"),
                [15] = new Litera("P"),
                [16] = new Litera("R"),
                [17] = new Litera("S"),
                [18] = new Litera("T"),
                [19] = new Litera("U"),
                [20] = new Litera("W"),
                [21] = new Litera("Z")
            };
            Iterator iterator = kolekcja.StworzIterator();
            // Chcemy wyświetlić co 3. literę
            iterator.Krok = 3;
            Console.WriteLine("Iterowanie po kolekcji liter wygląda tak:");
            for (var litera = iterator.Pierwszy(); !iterator.CzyKoniec;litera = iterator.Nastepny())
            {
                Console.WriteLine(litera.Nazwa);
            }
            Console.ReadKey();
        }
    }

    // Aplikacja pokazująca, jak działa iterator - dla polskiego alfabetu wyświetlimy co trzecią literę.
    class Litera
    {
        public Litera(string nazwa)
        {
            Nazwa = nazwa;
        }
        public string Nazwa { get; }
    }
    interface IKontener
    {
        Iterator StworzIterator();
    }
    // Specyficzny kontener:
    class Kolekcja : IKontener
    {
        private readonly ArrayList _litery = new ArrayList();
        public Iterator StworzIterator()
        {
            return new Iterator(this);
        }
        public int Licznik => _litery.Count;
        // Indekser
        public object this[int index]
        {
            get { return _litery[index]; }
            set { _litery.Add(value); }
        }
    }
    interface IAbstrakcyjnyIterator
    {
        Litera Pierwszy();
        Litera Nastepny();
        bool CzyKoniec { get; }
        Litera PobierzElement { get; }
    }
    class Iterator : IAbstrakcyjnyIterator
    {
        private readonly Kolekcja _kolekcja;
        private int _obecna;
        private int _krok;
        public Iterator(Kolekcja kolekcja)
        {
            _kolekcja = kolekcja;
        }
        public Litera Pierwszy()
        {
            _obecna = 0;
            return _kolekcja[_obecna] as Litera;
        }
        public Litera Nastepny()
        {
            _obecna += _krok;
            if (!CzyKoniec)
            {
                return _kolekcja[_obecna] as Litera;
            }
            return null;
        }
        public int Krok
        {
            set { _krok = value; }
        }
        public Litera PobierzElement => _kolekcja[_obecna] as Litera;
        public bool CzyKoniec => _obecna >= _kolekcja.Licznik;
    }
}
