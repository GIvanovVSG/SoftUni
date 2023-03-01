using System;

namespace _09._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = num1;i <= num2; i++)
            {
                for (int j = num1; j <= num2; j++)
                {
                    count ++;
                    if(i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magicNum})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{count} combinations - neither equals {magicNum}");
        }
    }
}
