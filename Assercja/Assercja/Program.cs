using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assercja
{
    class Program
    {
        public static float Divide(int dividend, int divisor)
        {
            Debug.Assert(divisor != 0);
            return (dividend / divisor);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Divide(5, 0));
            Console.ReadKey();
        }
    }
}
