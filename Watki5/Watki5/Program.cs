using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Watki5
{
    //kod z ksiazki Joseph Albahari, Ben Albahari, C\# 7.0 w pigułce, wyd. Helion, 2018.

    class Program
    {
        static void Main(string[] args)
        {
            new Thread(Go).Start(); 
            Go();
            Console.ReadKey();
        }

        static void Go()
        {
            for (int cycles = 0; cycles < 5; cycles++) Console.Write('?');
        }
    }
}
