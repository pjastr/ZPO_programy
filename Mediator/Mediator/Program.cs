using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    //kod z ksiązki * Daniel Krasnokucki, Wzorce projektowe. Leksykon kieszonkowy, Wyd. Helion 2017.

    class Program
    {
        static void Main(string[] args)
        {
            Chatroom chatroom = new Chatroom();
            Uzytkownik michal = new Koledzy("Michał");
            Uzytkownik tomek = new Rodzina("Tomek");
            Uzytkownik beata = new Rodzina("Beata");
            chatroom.Rejestruj(michal);
            chatroom.Rejestruj(tomek);
            chatroom.Rejestruj(beata);
            tomek.Wyslij("Michał", "Cześć, Michał, idziemy grać w piłkę?");
            beata.Wyslij("Tomek", "Wynieś śmieci!");
            tomek.Wyslij("Beata", "OK. Wrócę później.");
            Console.ReadKey();
        }
    }

    // Aplikacja pokazująca wykorzystanie mediatora przy implementacji czatu z grupami
    // Mediator
    abstract class AbstrakcyjnyCzat
    {
        public abstract void Rejestruj(Uzytkownik uzytkownik);
        public abstract void Wyslij(
        string nadawca, string odbiorca, string wiadomosc);
    }
    // Specyficzna implementacja mediatora
    class Chatroom : AbstrakcyjnyCzat
    {
        private readonly Dictionary<string, Uzytkownik> _uzytkownicy =
        new Dictionary<string, Uzytkownik>();
        public override void Rejestruj(Uzytkownik uzytkownik)
        {
            if (!_uzytkownicy.ContainsValue(uzytkownik))
            {
                _uzytkownicy[uzytkownik.Login] = uzytkownik;
            }
            uzytkownik.Chatroom = this;
        }
        public override void Wyslij(
        string nadawca, string odbiorca, string wiadomosc)
        {
            Uzytkownik uzytkownik = _uzytkownicy[odbiorca];
            uzytkownik?.Odbierz(nadawca, wiadomosc);
        }
    }
    class Uzytkownik
    {
        protected Uzytkownik(string login)
        {
            Login = login;
        }
        public string Login { get; }
        public Chatroom Chatroom { private get; set; }
        public void Wyslij(string odbiorca, string wiadomosc)
        {
            Chatroom.Wyslij(Login, odbiorca, wiadomosc);
        }
        public virtual void Odbierz(string nadawca, string wiadomosc)
        {
            Console.WriteLine($"{nadawca} odbiorca {Login}: '{wiadomosc}'");
        }
    }
    class Koledzy : Uzytkownik
    {
        public Koledzy(string login)
        : base(login)
        {
        }
        public override void Odbierz(string nadawca, string wiadomosc)
        {
            Console.Write("W grupie Koledzy: ");
            base.Odbierz(nadawca, wiadomosc);
        }
    }
    class Rodzina : Uzytkownik
    {
        public Rodzina(string login)
        : base(login)
        {
        }
        public override void Odbierz(string nadawca, string wiadomosc)
        {
            Console.Write("W grupie Rodzina: ");
            base.Odbierz(nadawca, wiadomosc);
        }
    }
}
