using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atrybuty4
{
    class Program
    {
        static void Main(string[] args)
        {
            OldMethod();
            Console.ReadKey();
        }

        [Obsolete("Proszę nie używać tej metody, nowa wersja: NewMethod()", true)]
        static void OldMethod()
        {
            Console.WriteLine("Stara, nieużywana metoda");
        }
        static void NewMehtod()
        {
            Console.WriteLine("Nowa wersja metody");
        }
    }
}
