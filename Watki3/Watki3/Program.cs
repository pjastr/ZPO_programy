using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Watki3
{
    class Program
    {
        static void Main(string[] args)
        {

            MyThreadClass oMyThreadClass = new MyThreadClass();
            Console.WriteLine(
                "Wprowadź wzrost w m oraz wagę w kg w postaci \"wzrost;waga\"");
            string sData = Console.ReadLine();
            Thread oThread = new Thread(new ParameterizedThreadStart(
                oMyThreadClass.GetBmi));
            oThread.Start(sData);
            oThread.Join();
        }
    }

    class MyThreadClass
    {
        public MyThreadClass()
        {
        }

        public void GetBmi(object oData)
        {
            string[] asData = oData.ToString().Split(';');
            Console.WriteLine(string.Format("Twoja wartość BMI: {0:f}",
                int.Parse(asData[1]) / Math.Pow(double.Parse(asData[0]), 2)));
            Console.WriteLine("Naciśnij dowolny klawisz...");
            Console.ReadKey();

        }
    }
}
