using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeNthBit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number...");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the position...");
            int p = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter value to change in 0 or 1.");
            int v = Int32.Parse(Console.ReadLine());
            n = (v == 0) ? (n & ~(1 << p)) : (n | (1 << p));
            Console.WriteLine("The result is : {0}", n);
            Console.ReadLine();
        }
    }
}
