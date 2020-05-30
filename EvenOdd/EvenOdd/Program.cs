using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            bool input = true;
            while (input)
            {
                Console.WriteLine("Enter a number : ");
                int number = Int32.Parse(Console.ReadLine());
                bool result = number % 2 == 0 ? true : false;
                if (result)
                {
                    Console.WriteLine("The given number {0} is an even number.", number);
                }
                else
                {
                    Console.WriteLine("The given number {0} is an odd number.", number);
                }
                Console.WriteLine("Do you want to continue ? Y/N");
                if(Console.ReadKey().Key == ConsoleKey.N)
                {
                    input = false;
                }
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    input = true;
                }
            }
            Console.ReadLine();
        }
    }
}
