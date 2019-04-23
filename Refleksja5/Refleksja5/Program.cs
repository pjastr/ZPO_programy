using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refleksja5
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            Console.WriteLine(t1.GetType().IsGenericType);
            TestGen<int> t2 = new TestGen<int>();
            Console.WriteLine(t2.GetType().IsGenericType);
            Type type;
            type = typeof(System.Nullable<>);
            Console.WriteLine(type.ContainsGenericParameters);
            Console.WriteLine(type.IsGenericType);
            type = typeof(System.Nullable<DateTime>);
            Console.WriteLine(type.ContainsGenericParameters);
            Console.WriteLine(type.IsGenericType);
            Console.ReadKey();
        }
    }

    class Test
    {

    }

    class TestGen<T>
    {

    }
}
