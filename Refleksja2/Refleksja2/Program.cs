using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refleksja2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestowaKlasa t1 = new TestowaKlasa();
            Console.WriteLine(t1.GetType().Name);
            Console.WriteLine(t1.GetType().IsPublic);
            Console.WriteLine(t1.GetType().BaseType);
            Console.WriteLine(t1.GetType().Assembly);
            foreach (var temp in t1.GetType().GetFields())
            {
                Console.WriteLine(temp.Name);
            }
            TestowaKlasa2 t2 = new TestowaKlasa2();
            Console.WriteLine(t2.GetType().IsPublic);
            Console.WriteLine(t2.GetType().BaseType);
            foreach (var temp in t2.GetType().GetInterfaces())
            {
                Console.WriteLine(temp.Name);
            }
            //Test3.GetType();
            Console.ReadKey();
        }
    }

    interface ITestable
    {
        int Met1(string param1);
    }

    class TestowaKlasa:TestowaKlasa2
    {
        public int poleLiczbowe = 0;
        string poleNapis;
    }

    public class TestowaKlasa2 : ITestable
    {
        public int Met1(string param1)
        {
            return param1.Length;
        }
    }

    static class Test3
    {

    }
}
