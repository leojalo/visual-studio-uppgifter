using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPPG16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = { 45, 12, 78, 34, 89, 23 };

            // Print the original array
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("\n");

            
            // Sort the array
            Array.Sort(numbers);

            // Print the sorted array
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine("\n");

            // Reverse the array
            Array.Reverse(numbers);

            // Print the reversed array
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine("\n");

            // Clear the array 
            int[] updatedNumbers = Array.FindAll(numbers, num => num != 78);
            foreach (int num in updatedNumbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("\n");


            // 6. Find the index of the number 34
            int index = Array.IndexOf(updatedNumbers, 34);
            if (index >= 0)
            {
                Console.WriteLine($"The index of 34 is: {index}");
            }
            else
            {
                Console.WriteLine("Number 34 does not exist in the array.");
            }


            Console.ReadLine();
        }
    }
}