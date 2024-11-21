using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPG4
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //User input "age"
            Console.Write("Enter Your Age: ");
            String ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            //Writes it out
            Console.WriteLine();
            Console.WriteLine(" your age is " + age);

            //if checking your age
            //== > >= < <= && 

            if (age >= 18)
            {
                Console.WriteLine("You are old and alowed to vote ");
            }
            else if (age <= 17)
            {
                Console.WriteLine("You are not alowed to vote");
            }







        }    
    }
}