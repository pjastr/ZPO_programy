using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pamiatka
{
    //kod z ksiazki Daniel Krasnokucki, Wzorce projektowe. Leksykon kieszonkowy, Wyd. Helion 2017.

    class Program
    {
        static void Main(string[] args)
        {
            var opiekun = new Opiekun
            {
                Nazwisko = "Jan Kowalski",
                Telefon = "(0-32) 5566777",
                Adres = "Bankowa 12"
            };
            // Zachowaj stan
            var m = new Zarzadca { Pamiatka = opiekun.UstawPamiatke() };
            // Zmiana naszego opiekuna
            opiekun.Nazwisko = "Andrzej Bankier";
            opiekun.Telefon = "600100200";
            opiekun.Adres = "Różana 12";
            // Przywrócimy stan dla testów
            opiekun.PrzywrocStan(m.Pamiatka);
            Console.ReadKey();
        }
    }

    // Będziemy zapamiętywali dane naszego opiekuna w banku,
    // po czym nadpiszemy je i przywrócimy.
    // Inicjator
    class Opiekun
    {
        private string _nazwisko;
        private string _telefon;
        private string _adres;
        public string Nazwisko
        {
            get { return _nazwisko; }
            set
            {
                _nazwisko = value;
                Console.WriteLine("Nazwisko: " + _nazwisko);
            }
        }
        public string Telefon
        {
            get { return _telefon; }
            set
            {
                _telefon = value;
                Console.WriteLine("Telefon: " + _telefon);
            }
        }
        public string Adres
        {
            get { return _adres; }
            set
            {
                _adres = value;
                Console.WriteLine("Adres: " + _adres);
            }
        }
        public Pamiatka UstawPamiatke()
        {
            Console.WriteLine("______Zachowano_______");
            return new Pamiatka(_nazwisko, _telefon, _adres);
        }
        public void PrzywrocStan(Pamiatka pamiatka)
        {
            Console.WriteLine("______Przywrócono______");
            Nazwisko = pamiatka.Nazwisko;
            Telefon = pamiatka.Telefon;
            Adres = pamiatka.Adres;
        }
    }

    class Pamiatka
    {
    // Konstruktor
    public Pamiatka(string nazwisko, string telefon, string adres)
        {
            Nazwisko = nazwisko;
            Telefon = telefon;
            Adres = adres;
        }
        public string Nazwisko { get; private set; }
        public string Telefon { get; private set; }
        public string Adres { get; private set; }
    }
    // Zarządzający, z ang. caretaker
    class Zarzadca
    {
        public Pamiatka Pamiatka { set; get; }
    }
}
