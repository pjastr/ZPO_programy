using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Watki8
{
    //kod z Joseph Albahari, Ben Albahari, C\# 7.0 w pigułce, wyd. Helion, 2018.

    class Program
    {
        static bool _done;
        static readonly object _locker = new object();

        static void Main(string[] args)
        {
            new Thread(Go).Start();
            Go();
            Console.ReadKey();
        }

        static void Go()
        {
            lock (_locker)
            {
                if (!_done) { Console.WriteLine("Gotowe"); _done = true; }
            }
        }
    }
}
