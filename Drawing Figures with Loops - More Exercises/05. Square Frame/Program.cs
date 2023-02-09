using System;

namespace _05._Square_Frame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int cols = 0; cols < n; cols++)
            {
                if(cols== 0 || cols == n-1)
                    Console.Write("+ ");
                else
                    Console.Write("| ");
                for (int rows = 0; rows < n - 2; rows++)
                {
                    Console.Write("- ");
                }
                if (cols == 0 || cols == n - 1)
                    Console.Write("+ ");
                else
                    Console.Write("| ");
                Console.WriteLine();
            }
        }
    }
}
