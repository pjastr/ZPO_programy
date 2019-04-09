using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Watki13
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(Go).Start();
        }

        static void Go()
        {
            try
            {
                // ...
                throw null;    // The NullReferenceException will get caught below
                               // ...
            }
            catch (Exception ex)
            {
                // Typically log the exception, and/or signal another thread
                // that we've come unstuck
                // ...
            }
        }
    }
}
