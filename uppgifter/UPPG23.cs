using System;

namespace UPPG23
{

    class Program
    {
        static void Main()
        {
            string input = "123";
            int number = 0;

            try
            {
                number = Convert.ToInt32(input);
                Console.WriteLine($"Conversion was successful: {number}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            if (TryParse(input, out number))
            {
                Console.WriteLine($"Custom parse was successful: {number}");
            }
            else
            {
                Console.WriteLine("Custom parse has failed.");
            }
        }

        static bool TryParse(string str, out int result)
        {
            try
            {
                result = Convert.ToInt32(str);
                return true;
            }
            catch (FormatException)
            {
                result = 0;
                return false;
            }
        }
    }
}
