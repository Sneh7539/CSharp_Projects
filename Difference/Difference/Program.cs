using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = false;
            float value1 = 13.123456789f;
            float value2 = 13.123456779f;
            float deduction = value1 - value2;
            deduction = Math.Abs(deduction);
            if(deduction < 0.000001)
            {
                result = true;
            }
            Console.WriteLine("{0}\n{1}\n{2}\n", value1, value2, result);
            Console.ReadLine();
        }
    }
}
