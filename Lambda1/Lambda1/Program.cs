using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda1
{
    //https://4programmers.net/C_sharp/Wyra%C5%BCenie_Lambda
    class Program
    {
        static void Main()
        {
            TestFoo.Foo();
            Console.ReadKey();
        }
    }

    class TestFoo
    {
        public static Func<int> Testuj()
        {
            int x = 5;
            Func<int> foo = () => x;
            x = 6;
            return foo;
        }

        public static void Foo()
        {
            var foo = Testuj();
            Console.WriteLine(foo());
        }
    }
}
