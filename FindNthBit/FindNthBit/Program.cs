using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNthBit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number...");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter a position...");
            int p = Int32.Parse(Console.ReadLine());
            if((((n >> p) & 1) == 1))
            {
                Console.WriteLine("{0} contains 1 at position {1}.", n, p);
            }
            else
            {
                Console.WriteLine("{0} contains 0 at position {1}.", n, p);
            }
            Console.ReadLine();
        }
    }
}
