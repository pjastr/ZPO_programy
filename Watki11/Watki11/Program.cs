using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Watki11
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread worker = new Thread(() => Console.ReadLine());
            if (args.Length > 0) worker.IsBackground = true;
            worker.Start();
        }
    }
}
