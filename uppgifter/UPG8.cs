using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UPG8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {

                {
                    Console.Write("Please enter your age: ");
                    string ageInput = Console.ReadLine();
                    int Age = int.Parse(ageInput);
                    const int LegalAge = 18;

                    if (Age >= LegalAge)
                    {
                        Console.WriteLine("You are an adult.");
                    }
                    else
                    {
                        Console.WriteLine("You are under the legal age.");
                    }

                    int Counter = 1;

                    while (Counter <= 5)
                    {
                        Console.WriteLine(Counter);
                        Counter++;
                    }

                    switch (Counter)
                    {
                        case 1:
                            Console.WriteLine("One");
                            break;
                        case 2:
                            Console.WriteLine("Two");
                            break;
                        case 3:
                            Console.WriteLine("Three");
                            break;
                        case 4:
                            Console.WriteLine("Four");
                            break;
                        case 5:
                            Console.WriteLine("Five");
                            break;
                        default:
                            Console.WriteLine("Please enter a number between 18-99");
                            break;
                    }

                    string name = "John";
                    Console.WriteLine($"Welcome, {name}! The loop has completed, and the final value of Counter was {Counter - 1}.");




                }
            }
        }
    }
}