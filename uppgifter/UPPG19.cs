using System;

namespace UPPG19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5 };
            Console.WriteLine("Array Length: " + numbers.Length);
            int sum = SumOfNumbers(numbers);

            if (sum > -1)
            {
                Console.WriteLine("The total is: " + sum);
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array");
            }

            if (numbers.Length == 0)
            {
                Console.WriteLine("Cannot add up an empty array");
            }
            else
            {
                bool hasNegative = false;
                foreach (int number in numbers)
                {
                    if (number < 0)
                    {
                        hasNegative = true;
                        break;
                    }
                }

                if (hasNegative)
                {
                    Console.WriteLine("Cannot add up an array with negative values.");
                }
                else
                {
                    Console.WriteLine("The total is: " + sum);
                }
            }
        }

        static int SumOfNumbers(int[] array)
        {
            int sum = 0;

            if (array.Length == 0)
            {
                return -1;
            }

            foreach (int number in array)
            {
                sum += number;
            }

            return sum;
        }
    }
}