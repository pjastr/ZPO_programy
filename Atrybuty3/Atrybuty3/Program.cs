using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atrybuty3
{
    class Program
    {
        static void method1()
        {
            DisplayMessage.Message("Wewnątrz metody 1");
            method2();
        }
        static void method2()
        {
            DisplayMessage.Message("Wewnątrz metody 2");
        }

        static void Main(string[] args)
        {
            DisplayMessage.Message("Wewnątrz głównej metody");
            method1();
            Console.ReadKey();
        }
    }

    class DisplayMessage
    {
        [Conditional("DEBUG")]
        public static void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
