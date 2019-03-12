using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MostWzorzec
{
    // kod ze strony https://pl.wikibooks.org/wiki/Kody_%C5%BAr%C3%B3d%C5%82owe/Most_(wzorzec_projektowy)

    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[2];
            shapes[0] = new CircleShape(1, 2, 3, new DrawingAPI1());
            shapes[1] = new CircleShape(5, 7, 11, new DrawingAPI2());

            foreach (Shape shape in shapes)
            {
                shape.ResizeByPercentage(2.5);
                shape.Draw();
            }
            Console.ReadKey();
        }
    }

    interface DrawingAPI
    {
        void DrawCircle(double x, double y, double radius);
    }

    /** "ConcreteImplementor" 1/2 */
    class DrawingAPI1 : DrawingAPI
    {
        public void DrawCircle(double x, double y, double radius)
        {
            System.Console.WriteLine("API1.circle at {0}:{1} radius {2}\n", x, y, radius);
        }
    }

    /** "ConcreteImplementor" 2/2 */
    class DrawingAPI2 : DrawingAPI
    {
        public void DrawCircle(double x, double y, double radius)
        {
            System.Console.WriteLine("API2.circle at {0}:{1} radius {2}\n", x, y, radius);
        }
    }

    /** "Abstraction" */
    interface Shape
    {
        void Draw();                             // low-level
        void ResizeByPercentage(double pct);     // high-level
    }

    /** "Refined Abstraction" */
    class CircleShape : Shape
    {
        private double x, y, radius;
        private DrawingAPI drawingAPI;

        public CircleShape(double x, double y, double radius, DrawingAPI drawingAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.drawingAPI = drawingAPI;
        }

        // low-level i.e. Implementation specific
        public void Draw()
        {
            drawingAPI.DrawCircle(x, y, radius);
        }

        // high-level i.e. Abstraction specific       
        public void ResizeByPercentage(double pct)
        {
            radius *= pct;
        }
    }
}
