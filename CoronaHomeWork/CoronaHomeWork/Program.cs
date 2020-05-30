using System;

namespace CoronaHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("1");
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("0");
                }
                if (i != 0)
                {
                    Console.Write("1");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
