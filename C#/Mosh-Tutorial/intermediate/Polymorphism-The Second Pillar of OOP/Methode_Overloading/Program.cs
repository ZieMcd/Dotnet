using System;
using System.Collections.Generic;

namespace Methode_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();

            shapes.Add(new Rectangle());
            shapes.Add(new Circle());

            var canvas = new Canvas();

            canvas.DrawShapes(shapes);
        }
    }
}
