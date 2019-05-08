using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid6
{
    //http://itcraftsman.pl/solidny-jak-solid-pisanie-solidnych-aplikacji-w-jezyku-c/
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public abstract class Facility
    {
        public abstract double CalculateSurface();
    }

    public class RectangularHouse : Facility
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalculateSurface()
        {
            return (2 * Height + 2 * Width);
        }
    }

    public class SquareHouse : Facility
    {
        public double Width { get; set; }

        public override double CalculateSurface()
        {
            return Math.Pow(Width, 2);
        }
    }

    public class TriangleHouse : Facility
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalculateSurface()
        {
            return (1 / 2 * Width * Height);
        }
    }

    public class CircleHouse : Facility
    {
        public double Radius { get; set; }

        public override double CalculateSurface()
        {
            return (Math.PI * Math.Pow(Radius, 2));
        }
    }
}
