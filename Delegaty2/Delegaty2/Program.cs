using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegaty2
{
    public delegate void Dzialanie(int x, int y);
    public class Matma
    {
        public void Dodaj(int l1, int l2) { Console.WriteLine(l1 + l2); }
        public void Odejmij(int l1, int l2) { Console.WriteLine(l1 - l2); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matma matma = new Matma();
            Dzialanie dzialanie = new Dzialanie(matma.Dodaj);
            dzialanie(5, 5);
            dzialanie += matma.Odejmij;
            dzialanie(7, 4);
            Console.ReadKey();
        }
    }

}
