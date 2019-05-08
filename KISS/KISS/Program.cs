using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KISS
{
    //kod ze strony http://itcraftsman.pl/uzyteczne-koncepty-projektowe-kiss-dry-yagni-tda-oraz-separation-of-concerns/
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    
    // zły przykład
    class notKISSClass1
    {
        int num1;
        int num2;

        public int Calculate1(int n1, int n2)
        {
            return n1 / n2;
        }

        int res1;

        public notKISSClass1()
        {
            res1 = Calculate1(num1, num2);
        }
    }

    //dobry przyklad
    public class NumberCalculator
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Result { get; set; }

        public NumberCalculator()
        {
            Result = DivideNumbers(Number1, Number2);
        }

        public int DivideNumbers(int Number1, int Number2)
        {
            return (Number1 / Number2);
        }
    }
}
