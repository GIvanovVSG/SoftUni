using System;
using System.Data;

namespace _06._Rhombus_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n; rows++)
            {
                Console.Write(new string(' ', n - rows));

                for (int stars = 1; stars <= rows; stars++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write(new string(' ', i));

                for (int stars = n - 1; stars >= i; stars--)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
