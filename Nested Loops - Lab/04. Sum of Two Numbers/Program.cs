using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int countCombination = 0;
            int trueCombination = 0;

            for (int i = num1; i <= num2; i++)
            {
                for (int k = num1; k <= num2; k++)
                {
                    countCombination++;

                    if (i + k == magic)
                    {
                        trueCombination++;
                        if (trueCombination == 1)
                        {
                            Console.WriteLine($"Combination N:{countCombination} ({i} + {k} = {magic})");
                            return;
                        }
                    }
                }
            }
            if (trueCombination == 0)
            {
                Console.WriteLine($"{countCombination} combinations - neither equals {magic}");
            }
        }
    }
}
