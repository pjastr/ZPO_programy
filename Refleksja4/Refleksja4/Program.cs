using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refleksja4
{
    //kod ze strony https://www.geeksforgeeks.org/typeof-operator-keyword-in-c-sharp/

    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello";
            Type a1 = typeof(string);
            Type a2 = s.GetType();
            Console.WriteLine(a1 == a2); 
            object obj = "Hello";
            Type b1 = typeof(object);
            Type b2 = obj.GetType();
            Console.WriteLine(b1 == b2);
            Console.ReadKey();
        }
    }
}
