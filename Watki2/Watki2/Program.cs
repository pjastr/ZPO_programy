using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Watki2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyThreadClass oMyThreadClass = new MyThreadClass();
            Thread oThread = new Thread(new ThreadStart(oMyThreadClass.Run));
            oThread.Start();
            Debug.WriteLine("Oczekiwanie na zakończenie wątku...");
            oThread.Join();
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
