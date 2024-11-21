using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPG7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Counter = 1;

            while (Counter <= 5)
            {
                Console.WriteLine("Counter: " + Counter);
                Counter++;
            }

            Console.WriteLine("The loop has finished.");

            Console.ReadLine();

        }
    }
}
