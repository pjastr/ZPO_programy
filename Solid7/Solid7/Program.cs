using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid7
{
    //http://itcraftsman.pl/solidny-jak-solid-pisanie-solidnych-aplikacji-w-jezyku-c/
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    abstract class Vehicle
    {
        public string Name { get; set; }
        public abstract void Drive();
    }

    class Taxi : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Dog runs");
        }
    }

    class AirPlane : Vehicle
    {
        public override void Drive()
        {
            throw new NotImplementedException();
        }
    }
}
