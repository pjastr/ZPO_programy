using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda2
{
    //https://4programmers.net/C_sharp/Wyra%C5%BCenie_Lambda

    class Program
    {
        static void Main()
        {
            TestFoo.WiekszeNizN(100);

            Console.ReadKey();
        }
    }

    class TestFoo
    {
        public static Func<int, bool> TestujacaFunkcja(int n)
        {
            return x => x > n;
        }

        public static void WiekszeNizN(int x)
        {
            var funkcja = TestujacaFunkcja(50);

            Console.WriteLine(funkcja(x));
        }
    }
}
