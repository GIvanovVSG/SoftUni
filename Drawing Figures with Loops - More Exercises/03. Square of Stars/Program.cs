using System;

namespace _03._Square_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int cols = 0; cols < n; cols++)
            {
                for (int rows = 0; rows < n; rows++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
