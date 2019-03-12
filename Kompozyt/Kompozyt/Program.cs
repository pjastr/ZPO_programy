using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kompozyt
{
    //kod ze strony http://lukaszkosiorowski.pl/programowanie/kompozyt-composite/   

    class Program
    {
        static void Main(string[] args)
        {
            Wizyta pacjent1 = new Wizyta("Pacjent Adam");
            pacjent1.Dodaj(new Przeglad("Przegląd"));

            UsuniecieUbytku usuniecieUbytku = new UsuniecieUbytku("Usunięcie ubytku");
            usuniecieUbytku.Dodaj(new Narzedzie1("Użycie narzędzia 1"));
            usuniecieUbytku.Dodaj(new Plombowanie("Plombowanie"));
            usuniecieUbytku.Dodaj(new Szlifowanie("Szlifowanie"));

            pacjent1.Dodaj(usuniecieUbytku);

            pacjent1.Wyswietl(2);
        }
    }

    interface IKomponent
    {
        int Cena { get; set; }
        string NazwaWyswietlana { get; set; }

        void Dodaj(IKomponent ob);
        void Usun(IKomponent ob);
        void Wyswietl(int przesuniecie);
    }

    class Wizyta : IKomponent
    {
        public int Cena { get; set; }
        public string NazwaWyswietlana { get; set; }
        private List<IKomponent> _dzieci = new List<IKomponent>();

        public Wizyta(string nazwa)
        {
            NazwaWyswietlana = nazwa;
        }

        public void Dodaj(IKomponent ob)
        {
            _dzieci.Add(ob);
            Cena += ob.Cena;
        }

        public void Usun(IKomponent ob)
        {
            _dzieci.Remove(ob);
            Cena -= ob.Cena;
        }

        public void Wyswietl(int przesuniecie)
        {
            Console.WriteLine(new String('-', przesuniecie) + String.Format("{0} : Cena {1} zł", NazwaWyswietlana, Cena));

            foreach (IKomponent ob in _dzieci)
            {
                ob.Wyswietl(przesuniecie + 2);
            }
        }
    }

    class UsuniecieUbytku : IKomponent
    {
        public int Cena { get; set; }
        public string NazwaWyswietlana { get; set; }
        private List<IKomponent> _dzieci = new List<IKomponent>();

        public UsuniecieUbytku(string nazwa)
        {
            NazwaWyswietlana = nazwa;
        }

        public void Dodaj(IKomponent ob)
        {
            _dzieci.Add(ob);
            Cena += ob.Cena;
        }

        public void Usun(IKomponent ob)
        {
            _dzieci.Remove(ob);
            Cena -= ob.Cena;
        }

        public void Wyswietl(int przesuniecie)
        {
            Console.WriteLine(new String('-', przesuniecie) + String.Format("{0} : Cena {1} zł", NazwaWyswietlana, Cena));

            foreach (IKomponent ob in _dzieci)
            {
                ob.Wyswietl(przesuniecie + 2);
            }
        }
    }


    class Przeglad : IKomponent
    {
        public int Cena { get; set; }
        public string NazwaWyswietlana { get; set; }

        public Przeglad(string nazwa)
        {
            NazwaWyswietlana = nazwa;
            Cena = 40;
        }

        public void Dodaj(IKomponent ob)
        {
            Console.WriteLine("Niedostępne dla tego elementu.");
        }

        public void Usun(IKomponent ob)
        {
            Console.WriteLine("Niedostępne dla tego elementu.");
        }

        public void Wyswietl(int przesuniecie)
        {
            Console.WriteLine(new String('-', przesuniecie) + String.Format("{0} : Cena {1} zł", NazwaWyswietlana, Cena));
        }
    }

    class Narzedzie1 : IKomponent
    {
        public int Cena { get; set; }
        public string NazwaWyswietlana { get; set; }

        public Narzedzie1(string nazwa)
        {
            NazwaWyswietlana = nazwa;
            Cena = 30;
        }

        public void Dodaj(IKomponent ob)
        {
            Console.WriteLine("Niedostępne dla tego elementu.");
        }

        public void Usun(IKomponent ob)
        {
            Console.WriteLine("Niedostępne dla tego elementu.");
        }

        public void Wyswietl(int przesuniecie)
        {
            Console.WriteLine(new String('-', przesuniecie) + String.Format("{0} : Cena {1} zł", NazwaWyswietlana, Cena));
        }
    }

    class Plombowanie : IKomponent
    {
        public int Cena { get; set; }
        public string NazwaWyswietlana { get; set; }

        public Plombowanie(string nazwa)
        {
            NazwaWyswietlana = nazwa;
            Cena = 50;
        }

        public void Dodaj(IKomponent ob)
        {
            Console.WriteLine("Niedostępne dla tego elementu.");
        }

        public void Usun(IKomponent ob)
        {
            Console.WriteLine("Niedostępne dla tego elementu.");
        }

        public void Wyswietl(int przesuniecie)
        {
            Console.WriteLine(new String('-', przesuniecie) + String.Format("{0} : Cena {1} zł", NazwaWyswietlana, Cena));
        }
    }

    class Szlifowanie : IKomponent
    {
        public int Cena { get; set; }
        public string NazwaWyswietlana { get; set; }

        public Szlifowanie(string nazwa)
        {
            NazwaWyswietlana = nazwa;
            Cena = 30;
        }

        public void Dodaj(IKomponent ob)
        {
            Console.WriteLine("Niedostępne dla tego elementu.");
        }

        public void Usun(IKomponent ob)
        {
            Console.WriteLine("Niedostępne dla tego elementu.");
        }

        public void Wyswietl(int przesuniecie)
        {
            Console.WriteLine(new String('-', przesuniecie) + String.Format("{0} : Cena {1} zł", NazwaWyswietlana, Cena));
        }
    }
    
}
