using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassandMethods
{

    abstract class shape
    {
        public abstract double GetArea();
    }


    class Circle : shape
    {
        public double Radius { get; }
         
        public Circle(double radius)
        {
            if (radius < 0) throw new ArgumentOutOfRangeException(nameof(radius), "Radius must be non-negative.");
            Radius = radius;
        }

        public override double GetArea() => Math.PI * Radius * Radius;
         
    }


    class Rectangle : shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle (double width, double height)
        {
            if (width < 0) throw new ArgumentOutOfRangeException(nameof(width), "Width must be non-negative.");
            if (height < 0) throw new ArgumentOutOfRangeException(nameof(height), "Radius must be non-negative.");
            Width = width;
            Height = height;
        }

        public override double GetArea() => Width * Height;
       
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3);
            Rectangle rectangle = new Rectangle(10, 18);


            Console.WriteLine($"Area of the Circle: {circle.GetArea():0.00}");
            Console.WriteLine($"Area of the Rectangle: {rectangle.GetArea():0.00}");
        }
    }
}
