using System;

namespace UPPG20
{
    class Circle
    {
        
        public double Radius { get; private set; }

        
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Calculates the area of the circle
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Circle circle = new Circle(1.5);

            // Calculates the area of the circle
            double area = circle.CalculateArea();

            // Prints the area of the circle in the console
            Console.WriteLine($"Area of the circle is: {area}");
        }
    }
}
