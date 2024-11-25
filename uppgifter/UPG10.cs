using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPPG10
{
    internal class Program
    {
        static void Main(string[] args)
        {







            // Step 1: Define six integer variables and assign values
            int num1 = 10, num2 = 20, num3 = 5, num4 = 6, num5 = 15, num6 = 7;

            // Step 2: Calculate the sum of num1 and num2
            int sum = num1 + num2;
            Console.WriteLine($"The sum of num1 and num2 is: {sum}");

            // Step 2: Calculate the product of num3 and num4
            int product = num3 * num4;
            Console.WriteLine($"The product of num3 and num4 is: {product}");

            // Step 2c Calculate the remainder of num5 divided by num6
            int remainder = num5 % num6;
            Console.WriteLine($"The remainder of num5 divided by num6 is: {remainder}");

            // Step 3: Increment and decrement operations on num6
            Console.WriteLine($"Original value of num6: {num6}");
            Console.WriteLine($"Postfix increment: {num6++} (value after increment: {num6})");
            Console.WriteLine($"Prefix increment: {++num6}");
            Console.WriteLine($"Postfix decrement: {num6--} (value after decrement: {num6})");
            Console.WriteLine($"Prefix decrement: {--num6}");

            // Step 4: Perform compound assignment operations on num5
            Console.WriteLine($"Original value of num5: {num5}");
            num5 += 5;
            Console.WriteLine($"After += 5: {num5}");
            num5 -= 3;
            Console.WriteLine($"After -= 3: {num5}");
            num5 *= 2;
            Console.WriteLine($"After *= 2: {num5}");
            num5 /= 4;
            Console.WriteLine($"After /= 4: {num5}");
            num5 %= 3;
            Console.WriteLine($"After %= 3: {num5}");
        }
    }
}
