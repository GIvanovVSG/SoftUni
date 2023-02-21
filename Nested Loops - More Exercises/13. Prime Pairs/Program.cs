using System;

namespace _13._Prime_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int diff1 = int.Parse(Console.ReadLine());
            int diff2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num1 + diff1; i++)
            {
                for (int j = num2; j <= num2 + diff2; j++)
                {
                    if(i > 2 && i % 2 != 0 && i > 3 && i % 3 != 0 && j > 2 && j % 2 != 0 && j > 3 &&
                        j % 3 != 0 && i > 5 && i % 5 != 0 && j > 5 && j % 5 != 0  && i > 7 && i % 7 != 0 && j > 7 && j % 7 != 0)
                    {
                        Console.WriteLine($"{i}{j}");
                    }
                }
            }
        }
    }
}
 