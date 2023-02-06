using System;

namespace _08._Equal_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int num1;
            int num2;
            int num3;
            int num4;
            int diff = 0;
            int sum1 = 0;
            int sum2 = 0;
            int maxDiff = 0;
            if (numbers != 1)
            {
                for (int i = 1; i < numbers; i++)
                {
                    num1 = int.Parse(Console.ReadLine());
                    num2 = int.Parse(Console.ReadLine());
                    sum1 = num1 + num2;

                    for (int j = 1; i < numbers; i++)
                    {
                        num3 = int.Parse(Console.ReadLine());
                        num4 = int.Parse(Console.ReadLine());
                        sum2 = num3 + num4;
                        if (sum1 != sum2)
                        {
                            if (sum1 > sum2)
                                diff = sum1 - sum2;
                            else
                                diff = sum2 - sum1;

                            if (diff > maxDiff)
                            {
                                maxDiff = diff;
                            }
                            else
                            {
                                sum1 = sum2;
                                sum2 = 0;
                            }
                        }
                    }
                }
                if (sum1 == sum2)
                {
                    Console.WriteLine($"Yes, value={sum1}");
                }
                else
                {
                    Console.WriteLine($"No, maxdiff={Math.Abs(maxDiff)}");
                }
            }
            else
            {
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                sum1 = num1 + num2;
                Console.WriteLine($"Yes, value={sum1}");
            }


        }
    }
}
