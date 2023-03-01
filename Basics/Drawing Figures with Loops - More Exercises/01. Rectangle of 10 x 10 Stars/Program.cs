using System;

namespace _01._Rectangle_of_10_x_10_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int cols = 0; cols < 10; cols++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
