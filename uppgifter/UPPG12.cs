﻿using System;

class UPPG12
{
    static void Main()
    {
        Console.WriteLine("Enter your password:");
        string password1 = Console.ReadLine();

        Console.WriteLine("Re-enter your password:");
        string password2 = Console.ReadLine();

        if (string.IsNullOrEmpty(password1) || string.IsNullOrEmpty(password2))
        {
            Console.WriteLine("Please enter a password.");
        }
        else if (password1.Length < 6 || password2.Length < 6)
        {
            Console.WriteLine("Password must be at least 6 characters long.");
        }
        else if (password1 == password2)
        {
            Console.WriteLine("Password match.");
        }
        else
        {
            Console.WriteLine("Passwords do not match.");
        }
    }
}
