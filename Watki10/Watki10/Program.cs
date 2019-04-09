using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Watki10
{
    //http://www.albahari.com/threading/

    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.Name = "main";
            Thread worker = new Thread(Go);
            worker.Name = "worker";
            worker.Start();
            Go();
        }

        static void Go()
        {
            Console.WriteLine("Hello from " + Thread.CurrentThread.Name);
        }
    }
}
