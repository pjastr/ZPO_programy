using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dekorator
{
    // kod pochodzi ze strony http://lukaszkosiorowski.pl/programowanie/dekorator-decorator/

    class Program
    {
        static void Main(string[] args)
        {
            KalkulatorProsty KalProsty = new KalkulatorProsty("Prosty");
            Console.WriteLine(KalProsty.WyswietlRodzajKalkulatora());

            KalkulatorNaukowy KalNau = new KalkulatorNaukowy(KalProsty, "Naukowy");
            Console.WriteLine(KalNau.WyswietlRodzajKalkulatora());

            Console.WriteLine(KalNau.Dodawanie(2, 2));
            Console.WriteLine(KalNau.PierwiastekStopnia2(4));
            Console.ReadLine();
        }
    }

    interface IKalkulator
    {
        string RodzajKalkulatora { get; set; }

        double Dodawanie(double a, double b);
        double Odejmowanie(double a, double b);
        double Dzielenie(double a, double b);
        double Mnozenie(double a, double b);
        string WyswietlRodzajKalkulatora();
    }

    class KalkulatorProsty : IKalkulator
    {
        public string RodzajKalkulatora { get; set; }

        public KalkulatorProsty(string rodzajKalkulatora)
        {
            RodzajKalkulatora = rodzajKalkulatora;
        }

        public double Dodawanie(double a, double b)
        {
            return a + b;
        }

        public double Odejmowanie(double a, double b)
        {
            return a - b;
        }

        public double Dzielenie(double a, double b)
        {
            if (b == 0.0)
            {
                return 0;
            }
            return a / b;
        }

        public double Mnozenie(double a, double b)
        {
            return a * b;
        }

        public string WyswietlRodzajKalkulatora()
        {
            return RodzajKalkulatora;
        }
    }

    abstract class Dekorator : IKalkulator
    {
        protected IKalkulator kalkulator;
        public string RodzajKalkulatora { get; set; }

        public Dekorator(IKalkulator ob)
        {
            kalkulator = ob;
        }

        public double Dodawanie(double a, double b)
        {
            return kalkulator.Dodawanie(a, b);
        }

        public double Odejmowanie(double a, double b)
        {
            return kalkulator.Odejmowanie(a, b);
        }

        public double Dzielenie(double a, double b)
        {
            return kalkulator.Dzielenie(a, b);
        }

        public double Mnozenie(double a, double b)
        {
            return kalkulator.Mnozenie(a, b);
        }

        public string WyswietlRodzajKalkulatora()
        {
            return kalkulator.WyswietlRodzajKalkulatora();
        }
    }

    class KalkulatorNaukowy : Dekorator
    {
        public KalkulatorNaukowy(IKalkulator ob, string b) : base(ob)
        {
            RodzajKalkulatora = b;
        }

        public double PierwiastekStopnia2(double a)
        {
            if (a < 0)
                return 0;
            return Math.Sqrt(a);
        }

        public new string WyswietlRodzajKalkulatora()
        {
            return RodzajKalkulatora;
        }
    }


}
