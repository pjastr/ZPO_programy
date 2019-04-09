using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Watki12
{
    //http://www.albahari.com/threading/
    //nie właściwe uzycie wyjątków

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                new Thread(Go).Start();
            }
            catch (Exception ex)
            {
                // We'll never get here!
                Console.WriteLine("Exception!");
            }
        }

        static void Go()
        {
            throw null;
        }
    }
}
