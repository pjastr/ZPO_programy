using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Watki6
{
    //kod z Joseph Albahari, Ben Albahari, C\# 7.0 w pigułce, wyd. Helion, 2018.

    class ThreadTest
    {
        bool _done;

        static void Main(string[] args)
        {
            ThreadTest tt = new ThreadTest(); 
            new Thread(tt.Go).Start();
            tt.Go();
            Console.ReadKey();
        }

        void Go() 
        {
            if (!_done) { _done = true; Console.WriteLine("Gotowe"); }
        }
    }
}
