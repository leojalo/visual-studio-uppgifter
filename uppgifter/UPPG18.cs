using System;

namespace UPPG18
{
    class Program
    {
        // Function to calculate the area of your triangle
        static double CalculateArea(double width, double height)
        {
            return (width * height) / 2;
        }

        static void Main(string[] args)
        {
            // Ask the user for the width of the triangle
            Console.Write("Please enter the width of the triangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            // Ask the user for the height of the triangle
            Console.Write("Please enter the height of the triangle: ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Calculates the area of your triangle
            double area = CalculateArea(width, height);

            // Prints your triangles area
            Console.WriteLine($"The area of your triangle is {area}");
        }
    }
}