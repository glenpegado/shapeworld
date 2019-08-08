using System;
using ShapeWorld.Domain.Models;

namespace ShapeWorld.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PlayWithShape();
        }

        private static void PlayWithShape()
        {
            Square someSquare = new Square();
            Rectangle someShape = new Rectangle();
            Rectangle someRectangle = new Rectangle() as Square;

            Triangle someTriangle = new Triangle();


            someSquare.Length = 10;
            someSquare.Length = 100;

            Console.WriteLine(someShape.Volume());
            Console.WriteLine(someSquare.NumberOfEdges);
            Console.WriteLine(someTriangle.NumberOfEdges);

        }
    }
}

// Triangle 2d
// Circle 2d

// Sphere 3d
// Cube 3d
