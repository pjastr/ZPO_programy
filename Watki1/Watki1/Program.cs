using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Watki1
{
    //kod z ksiazki Joseph Albahari, Ben Albahari, C\# 7.0 w pigułce, wyd. Helion, 2018.

    class Program
    {
        static void Main(string[] args)
        {

            Thread t = new Thread(WriteY); 
            t.Start(); 
                       
            for (int i = 0; i < 1000; i++) Console.Write("x");
            Console.ReadKey();
        }

        static void WriteY()
        {
            for (int i = 0; i < 1000; i++) Console.Write("y");
        }
    }


}
