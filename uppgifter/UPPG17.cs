using System;
using System.Collections.Generic;

namespace UPPG17
{

    class Program
    {
        
        static Dictionary<string, string> subjects = new Dictionary<string, string>();

        static void DisplayMenu()
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1 - Add a new subject");
            Console.WriteLine("2 - Remove a subject");
            Console.WriteLine("3 - Display all subjects and their teachers");
            Console.WriteLine("4 - Exit");
        }

        static void AddSubject()
        {
            Console.Write("Enter the name of the new subject: ");
            string subject = Console.ReadLine().Trim();

            Console.Write("Enter the teacher's name for this subject: ");
            string teacher = Console.ReadLine().Trim();

            if (subjects.ContainsKey(subject))
            {
                Console.WriteLine($"The subject '{subject}' already exists. Updating the teacher's name.");
            }

            subjects[subject] = teacher;
            Console.WriteLine($"Subject '{subject}' added/updated successfully!");
        }

        static void RemoveSubject()
        {
            Console.Write("Enter the name of the subject to remove: ");
            string subject = Console.ReadLine().Trim();

            if (subjects.ContainsKey(subject))
            {
                subjects.Remove(subject);
                Console.WriteLine($"Subject '{subject}' removed successfully!");
            }
            else
            {
                Console.WriteLine($"Error: Subject '{subject}' not found.");
            }
        }

        static void DisplaySubjects()
        {
            if (subjects.Count > 0)
            {
                Console.WriteLine("\nSubjects and their teachers:");
                foreach (var pair in subjects)
                {
                    Console.WriteLine($"- {pair.Key}: {pair.Value}");
                }
            }
            else
            {
                Console.WriteLine("No subjects found.");
            }
        }

        static void Main()
        {
            while (true)
            {
                DisplayMenu();

                Console.Write("Select an option (1-4): ");
                string input = Console.ReadLine().Trim();

                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddSubject();
                            break;
                        case 2:
                            RemoveSubject();
                            break;
                        case 3:
                            DisplaySubjects();
                            break;
                        case 4:
                            Console.WriteLine("Exiting the program. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid input. Please select a number between 1 and 4.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                }
            }
        }
    }
}
