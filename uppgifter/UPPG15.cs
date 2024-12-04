using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPPG15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 5, 25, 30 };
            int max = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine($"The maximum value in the array is: {max}");



            Console.ReadLine();
        }
    }
}
