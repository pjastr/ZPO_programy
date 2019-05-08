using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid5
{
    //http://itcraftsman.pl/solidny-jak-solid-pisanie-solidnych-aplikacji-w-jezyku-c/
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class House
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public string Type { get; set; }
    }

    public class SurfaceCalculator
    {
        public double CalculateSurface(House house)
        {
            if (house.Type == "SquareHouse")
            {
                return Math.Pow(house.Width, 2);
            }
            else if (house.Type == "RectangularHouse")
            {
                return (2 * house.Height + 2 * house.Width);
            }
            else
            {
                return (house.Height * house.Width);
            }

        }
    }


}
