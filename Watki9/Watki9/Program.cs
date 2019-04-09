using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Watki9
{
    //http://www.albahari.com/threading/

    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(Go));

            t.Start();   
            Go();
            Console.ReadKey();
        }

        static void Go()
        {
            Console.WriteLine("hello!");
        }
    }
}
