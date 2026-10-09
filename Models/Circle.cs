using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Models
{
    internal class Circle
    {
        private const double LimitValueForBigShape = 100.0;
        private double _radius;
        private double _centerX;
        private double _centerY;
        private string _color;

        public double Radius { get => _radius; set => _radius = value; }
        public double CenterX { get => _centerX; set => _centerX = value; }
        public double CenterY { get => _centerY; set => _centerY = value; }
        public string Color { get => _color; set => _color = value; }

        public string DescribeSize()
        {
            if (CalculateArea() > LimitValueForBigShape)
                return "I am big!!!";
            else
                return "I am small!!!";
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public Circle(double radius, double centerX, double centerY, string color)
        {
            this.Radius = radius;
            this.CenterX = centerX;
            this.CenterY = centerY;
            this.Color = color;
        }

        public Circle(double radius)
        {
            this.Radius = radius;
            this.CenterX = 0;
            this.CenterY = 0;
            this.Color = "white";
        }

        public Circle()
        {
            this.Radius = 1;
            this.CenterX = 0;
            this.CenterY = 0;
            this.Color = "white";
        }
        public static string Definition()
        {
            return "A circle is a collection of points that all have the same distance to a center point.";
        }
    }
}
