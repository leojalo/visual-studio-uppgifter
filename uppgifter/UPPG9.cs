using System;

class Program
{
    static void Main()
    {
        // Define four integer variables
        int num1 = 10, num2 = 20, num3 = 5, num4 = 10; // num4 is the same as num1

        // Define a boolean variable and assign it true
        bool isTrue = true;

        // Perform logical operations and print the results
        bool resultAnd = isTrue && (num1 > num3 && num2 < num4);
        bool resultOr = isTrue || (num1 < num3 || num2 > num4);
        bool resultNot = !isTrue;

        Console.WriteLine("Logical AND result: " + resultAnd);
        Console.WriteLine("Logical OR result: " + resultOr);
        Console.WriteLine("Logical NOT result: " + resultNot);

        // Perform comparison operations and print the results
        Console.WriteLine("Is num1 greater than num3? " + (num1 > num3));
        Console.WriteLine("Is num2 less than num4? " + (num2 < num4));
        Console.WriteLine("Is num1 equal to num4? " + (num1 == num4));
        Console.WriteLine("Is num2 not equal to num3? " + (num2 != num3));

        // Define two boolean expressions
        bool expression1 = (num1 > num3) && (num2 < num4);
        bool expression2 = (num1 < num3) || (num2 > num4);

        // Print expression1 and expression2
        Console.WriteLine("Expression1: " + expression1);
        Console.WriteLine("Expression2: " + expression2);

        // Run the program
    }
}