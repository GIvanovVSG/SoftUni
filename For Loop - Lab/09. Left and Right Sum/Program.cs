using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < numbers; i ++)
            {
                int numLeft = int.Parse(Console.ReadLine());
                
                sumLeft += numLeft;
            }

            for (int i = 0; i < numbers; i++)
            {
                int numRight = int.Parse(Console.ReadLine());

                sumRight += numRight;
            }

            if (sumLeft == sumRight)
            {
                Console.WriteLine($"Yes, sum = {sumLeft}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumLeft - sumRight)}");
            }
        }
    }
}
