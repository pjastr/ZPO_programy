using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PyłekWzorzec
{
    class Program
    {
        //kod pochodzi z ksiązki Daniel Krasnokucki, Wzorce projektowe. Leksykon kieszonkowy, Wyd. Helion 2017.

        static void Main(string[] args)
        {
            // Stwórzmy dokument z dowolnym tekstem
            const string dokument = "BACABBAACCCAB";
            var znaki = dokument.ToCharArray();
            var fabryka = new FabrykaZnakow();
            // Stan początkowy
            int wielkosc = 10;
            // Dla każdej litery użyj odpowiedniego pyłku i zwiększ wielkość, abyśmy widzieli różnicę
            foreach (char c in znaki)
            {
                wielkosc++;
                var litera = fabryka.PobierzLitere(c);
                litera.Wyswietl(wielkosc);
            }
            Console.ReadKey();
        }
    }

    // Fabryka pyłków
    class FabrykaZnakow
    {
        private readonly Dictionary<char, Litera> _litery =
        new Dictionary<char, Litera>();
        public Litera PobierzLitere(char znak)
        {
            Litera litera = null;
            if (_litery.ContainsKey(znak))
            {
                litera = _litery[znak];
            }
            else
            {
                switch (znak)
                {
                    case 'A': litera = new LiteraA(); break;
                    case 'B': litera = new LiteraB(); break;
                    case 'C': litera = new LiteraC(); break;
                }
                _litery.Add(znak, litera);
            }
            return litera;
        }
    }
    // Abstrakcyjna klasa reprezentująca pyłek
    abstract class Litera
    {
        protected char Znak;
        protected int Rozmiar;
        public abstract void Wyswietl(int wielkosc);
    }

    // Specyficzny pyłek
    class LiteraA : Litera
    {
        public LiteraA()
        {
            Znak = 'A';
        }
        public override void Wyswietl(int wielkosc)
        {
            Rozmiar = wielkosc;
            Console.WriteLine($"{Znak} (wielkosc: {Rozmiar})");
        }
    }
    // Specyficzny pyłek
    class LiteraB : Litera
    {
        // Konstruktor
        public LiteraB()
        {
            Znak = 'B';
        }
        public override void Wyswietl(int wielkosc)
        {
            Rozmiar = wielkosc;
            Console.WriteLine($"{Znak} (wielkosc: {Rozmiar})");
        }
    }
    // Można tak zadeklarować więcej liter... My pozostaniemy przy 3.
    class LiteraC : Litera
    {
        public LiteraC()
        {
            Znak = 'C';
        }
        public override void Wyswietl(int wielkosc)
        {
            Rozmiar = wielkosc;
            Console.WriteLine($"{Znak} (wielkosc: {Rozmiar})");
        }
    }
}
