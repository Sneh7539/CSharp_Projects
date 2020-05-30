using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number...");
            string number = Console.ReadLine().Trim();
            if((number.Length >= 3) && (number[number.Length - 3] == '7'))
            {
                Console.WriteLine("Third digit of given number {0} is 7.", number);
            }
            else
            {
                Console.WriteLine("Third digit of given number {0} is not 7.", number);
            }
            Console.ReadLine();
        }
    }
}
