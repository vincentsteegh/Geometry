using Geometry.Models;
using System;

namespace Geometry

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Circle myFirstCircle = new Circle();
            //myFirstCircle.Radius = 3;
            //myFirstCircle.CenterX = 3;
            //myFirstCircle.CenterY = -2;
            //myFirstCircle.Color = "Green";

            //Console.WriteLine(myFirstCircle.CalculatePerimeter());
            //Console.WriteLine(myFirstCircle.CalculateArea());

            //Console.WriteLine(Circle.Definition());
            //Circle myAllArgsCircle = new Circle(3, 1, 4, "green");
            //Console.WriteLine(myAllArgsCircle.CalculatePerimeter());
            //Console.WriteLine(myAllArgsCircle.CalculateArea());

            //Circle myRadiusCircle = new Circle(6);
            //Console.WriteLine(myRadiusCircle.CalculatePerimeter());
            //Console.WriteLine(myRadiusCircle.CalculateArea());

            //Circle myDefaultCircle = new Circle();
            //Console.WriteLine(myDefaultCircle.CalculatePerimeter());
            //Console.WriteLine(myDefaultCircle.CalculateArea());
            Circle myDefaultCircle = new Circle();
            Console.WriteLine(myDefaultCircle.Radius);
            Console.WriteLine(myDefaultCircle.CalculateArea());
            Console.WriteLine(myDefaultCircle.DescribeSize());
            myDefaultCircle.Radius = 8;
            Console.WriteLine(myDefaultCircle.CalculateArea());
            Console.WriteLine(myDefaultCircle.DescribeSize());
            myDefaultCircle.Radius = 6;
            Console.WriteLine(myDefaultCircle.CalculateArea());
            Console.WriteLine(myDefaultCircle.DescribeSize());

            //Circle myDefaultCircle = new Circle();
            //Console.WriteLine(myDefaultCircle.Radius);
            //Console.WriteLine(myDefaultCircle.CalculatePerimeter());
            //Console.WriteLine(myDefaultCircle.CalculateArea());
            //myDefaultCircle.Radius = 3;
            //Console.WriteLine(myDefaultCircle.CalculatePerimeter());
            //Console.WriteLine(myDefaultCircle.CalculateArea());

        }
    }
}