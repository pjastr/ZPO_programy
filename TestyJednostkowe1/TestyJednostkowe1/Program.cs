using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestyJednostkowe1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public static class Calculator
    {
        public static string Multiply(float arg1, float arg2)
        {
            return (arg1 * arg2).ToString();
        }

        public static string Divide(float arg1, float arg2)
        {
            return (arg1 % arg2).ToString();
        }

        public static string Adding(float arg1, float arg2)
        {
            return (arg1 + arg2).ToString();
        }

        public static string Substract(float arg1, float arg2)
        {
            Thread.Sleep(4000);
            return (arg1 - arg2).ToString();
        }

    }
}
