using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPPG13
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
    
         // Asks the user to enter a number
         Console.Write("Enter a number: ");

        
            int number;
         if (int.TryParse(Console.ReadLine(), out number))
           
                // Check if the number is odd or not
                if (number % 2 == 0)
                {
                    // Displays a message if the number is even
                    Console.WriteLine($"The number {number} is even.");
                }
                else
                {
                   // Displays a message if the number is odd
                   Console.WriteLine($"The number {number} is odd.");
                }
          
          else
           
              // invalid input
              Console.WriteLine("Invalid input, please enter a number.");
        }
    }
}