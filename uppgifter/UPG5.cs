using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPG5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your grade 0-5 : ");
            int grade = Convert.ToInt32(Console.ReadLine());


            switch (grade)
            {
                case 0:
                    Console.WriteLine("Fail");
                    break;
                case 1:
                    Console.WriteLine("Needs Improvement");
                    break;
                case 2:
                    Console.WriteLine("Ok");
                    break;
                case 3:
                    Console.WriteLine("Satisfactory");
                    break;
                case 4:
                    Console.WriteLine("Good");
                    break;
                case 5:
                    Console.WriteLine("Excellent");
                    break;

               
                default:
                    Console.WriteLine("Invalid, enter a value between 0 and 5");
                    break;
            }
            Console.ReadLine();
        }
    }
}
