using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refleksja6
{
    class Program
    {
        public static string Test { get; set; } = "Przykład";

        static void Method()
        {
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Name of namespace: {0}", nameof(Refleksja6));
            Console.WriteLine("Name of class: {0}", nameof(Program));
            Console.WriteLine("Name of object: {0}", nameof(StringBuilder));
            Console.WriteLine("Name of method: {0}", nameof(Method));
            Console.WriteLine("Name of struct: {0}", nameof(DateTime));
            Console.WriteLine("Name of field: {0}", nameof(Test));
            Console.ReadKey();
        }
    }
}
