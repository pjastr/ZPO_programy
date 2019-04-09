using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegaty1
{
    public delegate int Transformer(int x);

    class Program
    {
        static int Square(int x) { return x * x; }
        static void Main(string[] args)
        {
            Transformer t = Square; // utworzenie egzemplarza delegatu
            int result = t(3); // wywołanie delegatu
            Console.WriteLine(result); // 9
            Console.ReadKey();
        }
    }

}
