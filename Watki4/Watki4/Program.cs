using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace Watki4
{
    //kod ze strony http://www.altcontroldelete.pl/artykuly/wielowatkowosc-w-c-wprowadzenie/

    class Program
    {
        static void Main(string[] args)
        {
            MyThreadClass oMyThreadClass = new MyThreadClass();
            Thread oThread = new Thread(new ThreadStart(oMyThreadClass.Run));
            oThread.Start();
            if (oThread.IsAlive)
            {
                oThread.Abort();
            }
        }
    }

    class MyThreadClass
    {
        public MyThreadClass()
        {
        }

        public void Run()
        {
            Debug.WriteLine("Rozpoczynam pracę...");
            // Jakieś długie operacje
            Debug.WriteLine("Test uśpienia wątku...");
            Thread.Sleep(500);
            Debug.WriteLine("Kończę pracę...");
        }
    }
}
