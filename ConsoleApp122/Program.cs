using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp122
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumbers = new Random();

            for (int counter = 1; counter <= 20; counter++)
            {
                int face = randomNumbers.Next(1, 7);
                Console.Write($"{face}");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
