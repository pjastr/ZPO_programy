using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atrybuty1
{
    //kod ze strony https://www.plukasiewicz.net/Csharp_dla_zaawansowanych/Atrybuty

    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    // Atrybut, który może być dołączony do 
    // klasy, konstruktora, pola, właściowości
    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Constructor |
        AttributeTargets.Field |
        AttributeTargets.Property,
        AllowMultiple = true)]
    class HelpAttribute : Attribute
    {
        // Klasa, która używa atrybutu AttributeUsage musi dziedziczyć
        // z klasy Attribute
        protected string description;
        public HelpAttribute(string Description)
        {
            // this mówi nam, że odwołujemy się do składowej danej klasy
            // nie jest to wymagane ale pozwoli jednoznacznie określić
            // że chcemy do pola naszej klasy przypisać wartość z konstruktora
            this.description = Description;
        }
    }
    [Help("Ta klasa nic nie robi")]
    class Przyklad1
    {
        public Przyklad1()
        {
        }
        // Atrybut ten nie może zostać użyty w tej metodzie gdyż zostało to 
        // zabronione przy definicji atrybutu AttributeUsage
        [Help("Ta metoda nic nie robi")]
        public void Metoda1()
        {

        }
    }
}
