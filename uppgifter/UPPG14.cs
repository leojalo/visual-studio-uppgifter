using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Initialize two integers
        int num = 7;
        int length = 5;

        // Step 2: Create an integer array with a size equal to length
        int[] multiplicationTable = new int[length];

        // Step 3 & 4: Generate the multiplication table and insert into the array
        for (int i = 0; i < length; i++)
        {
            multiplicationTable[i] = (i + 1) * num;
        }

        // Step 5: Print the final array
        Console.WriteLine($"Multiplication Table for {num}:");
        for (int i = 0; i < multiplicationTable.Length; i++)
        {
            Console.WriteLine($"{i + 1} x {num} = {multiplicationTable[i]}");
        }
    }
}
 