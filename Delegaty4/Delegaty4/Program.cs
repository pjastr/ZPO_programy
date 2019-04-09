using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegaty4
{
    class Program
    {
        static void Main()
        {
            Action<string> wypisz = System.Console.WriteLine;
            wypisz("jakis tekst");
            Console.ReadKey();
        }

    }
}
