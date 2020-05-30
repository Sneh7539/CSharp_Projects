using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number...");
            int number = Int32.Parse(Console.ReadLine());
            int value = 1 << 3;
            int bitAt3 = (number & value) != 0 ? 1 : 0;
            value = 1 << 4;
            int bitAt4 = (number & value) != 0 ? 1 : 0;
            value = 1 << 5;
            int bitAt5 = (number & value) != 0 ? 1 : 0;
            value = 1 << 24;
            int bitAt24 = (number & value) != 0 ? 1 : 0;
            value = 1 << 25;
            int bitAt25 = (number & value) != 0 ? 1 : 0;
            value = 1 << 26;
            int bitAt26 = (number & value) != 0 ? 1 : 0;

            value = (bitAt3 == 0) ? (value & (~(1 << 24))) : (value | (1 << 24));
            value = (bitAt4 == 0) ? (value & (~(1 << 25))) : (value | (1 << 25));
            value = (bitAt5 == 0) ? (value & (~(1 << 26))) : (value | (1 << 26));
            value = (bitAt24 == 0) ? (value & (~(1 << 3))) : (value | (1 << 3));
            value = (bitAt25 == 0) ? (value & (~(1 << 4))) : (value | (1 << 4));
            value = (bitAt26 == 0) ? (value & (~(1 << 5))) : (value | (1 << 5));

            Console.WriteLine("The result is : {0}", value);
            Console.ReadLine();
        }
    }
}
