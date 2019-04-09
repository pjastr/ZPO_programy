using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Taski
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = new Task(delegate ()
                        {
                            Console.Write("task 1");
                            Thread.Sleep(5000);
                        }
            );
            Task t2 = t1.ContinueWith((t) => Console.Write("task 2"));
            t1.Start();
            t2.Wait();
            Console.ReadKey();
        }
    }
}
