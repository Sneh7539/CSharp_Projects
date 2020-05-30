using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    class Program
    {
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            int a = 5; //Assigning the values to the variable a
            int b = 10; //Assigning the values to the variable b
            Console.WriteLine("Method - 1"); //Swapping values by using anonymous function names Swap()
            Console.WriteLine("Before Swapping...");
            Console.WriteLine("a = {0}\nb = {1}\n", a, b);
            Program.Swap<int>(ref a, ref b);
            Console.WriteLine("After Swapping...");
            Console.WriteLine("a = {0}\nb = {1}\n", a, b);
            Console.WriteLine("******************");


            Console.WriteLine("Method - 2"); //Swapping values by using addition and subtraction method
            Console.WriteLine("Before Swapping...");
            Console.WriteLine("a = {0}\nb = {1}\n", a, b); //a = 10; b = 5;
            a = a + b; //a = 15;
            b = a - b; //b = 10;
            a = a - b; //a = 5;
            Console.WriteLine("After Swapping...");
            Console.WriteLine("a = {0}\nb = {1}\n", a, b);
            Console.WriteLine("******************"); //a = 5; b = 10;


            Console.WriteLine("Method - 3"); //Swapping values by using XOR method
            Console.WriteLine("Before Swapping...");
            Console.WriteLine("a = {0}\nb = {1}\n", a, b); //a = 5; b = 10;
            a = a ^ b; //a = 15;
            b = a ^ b; //b = 5;
            a = a ^ b; //a = 10;
            Console.WriteLine("After Swapping...");
            Console.WriteLine("a = {0}\nb = {1}\n", a, b); //a = 10; b = 5;
            Console.WriteLine("******************");


            Console.WriteLine("Method - 4"); //Swapping values by using multiplication and division method
            Console.WriteLine("Before Swapping...");
            Console.WriteLine("a = {0}\nb = {1}\n", a, b); //a = 10; b = 5;
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After Swapping...");
            Console.WriteLine("a = {0}\nb = {1}\n", a, b); //a = 5; b = 10;
            Console.WriteLine("******************");
            Console.ReadLine();
        }
    }
}
