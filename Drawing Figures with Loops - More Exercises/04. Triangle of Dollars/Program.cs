using System;

namespace _04._Triangle_of_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int cols = 0; cols < n; cols++)
            {
                for (int rows = 0; rows <= cols; rows++)
                {
                    Console.Write("$ ");
                }

                Console.WriteLine();
            }
        }
    }
}
