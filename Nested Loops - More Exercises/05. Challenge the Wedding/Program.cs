using System;

namespace _05._Challenge_the_Wedding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mens = int.Parse(Console.ReadLine());
            int womans = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());
            int count = 0;

            for (int t = 1; t <= tables; t++)
            {
                for (int m = 1; m <= mens; m++)
                {
                    for (int f = 1; f <= womans; f++)
                    {
                        Console.Write($"({m} <-> {f}) ");
                        count++;

                        if(f == womans && m == mens || count == tables)
                        {
                            return;
                        }
                    }
                }
            }
        }
    }
}
