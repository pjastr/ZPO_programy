using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refleksja3
{
    //kod ze strony https://www.geeksforgeeks.org/typeof-operator-keyword-in-c-sharp/

    class Program
    {
        static Type a = typeof(double);

        static void Main(string[] args)
        {
            Console.WriteLine(a);
            Console.WriteLine(typeof(int));
            Console.WriteLine(typeof(Array));
            Console.WriteLine(typeof(char));
            Console.WriteLine(typeof(int[]));
            Console.ReadKey();
        }
    }
}
