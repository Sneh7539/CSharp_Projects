using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdBit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int number = Int32.Parse(Console.ReadLine());
            if (((number >> 3) & 1) == 1)
            {
                Console.WriteLine("{0} has third bit 1.",number);
            }
            else
                Console.WriteLine("{0} has not third bit 1.",number);
            Console.ReadLine();
        }
    }
}
