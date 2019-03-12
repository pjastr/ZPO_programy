using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PelnomocnikWzorzec
{
    //kod pochodzi z książki Daniel Krasnokucki, Wzorce projektowe. Leksykon kieszonkowy, Wyd. Helion 2017.

    class Program
    {
        static void Main(string[] args)
        {
            // Tworzymy pełnomocnika
            var proxy = new OperacjeMatematyczneProxy();
            // Wykonujemy działania
            Console.WriteLine($"6 + 3 = {proxy.Dodaj(6, 3)}");
            Console.WriteLine($"6 - 3 = {proxy.Odejmij(6, 3)}");
            Console.WriteLine($"6 * 3 = {proxy.Pomnoz(6, 3)}");
            Console.WriteLine($"6 / 3 = {proxy.Podziel(6, 3)}");
            Console.ReadKey();
        }
    }

    public interface IOperacjeMatematyczne
    {
        double Dodaj(double x, double y);
        double Odejmij(double x, double y);
        double Pomnoz(double x, double y);
        double Podziel(double x, double y);
    }
    class OperacjeMatematyczne : IOperacjeMatematyczne
    {
        public double Dodaj(double x, double y) { return x + y; }
        public double Odejmij(double x, double y) { return x - y; }
        public double Pomnoz(double x, double y) { return x * y; }
        public double Podziel(double x, double y) { return x / y; }
    }

    // Pełnomocnik
    class OperacjeMatematyczneProxy : IOperacjeMatematyczne
    {
        private readonly OperacjeMatematyczne _operacjeMatematyczne = new OperacjeMatematyczne();
        public double Dodaj(double x, double y)
        {
            return _operacjeMatematyczne.Dodaj(x, y);
        }
        public double Odejmij(double x, double y)
        {
            return _operacjeMatematyczne.Odejmij(x, y);
        }
        public double Pomnoz(double x, double y)
        {
            return _operacjeMatematyczne.Pomnoz(x, y);
        }
        public double Podziel(double x, double y)
        {
            return _operacjeMatematyczne.Podziel(x, y);
        }
    }
}
