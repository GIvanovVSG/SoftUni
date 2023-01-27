using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            string input;

            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                double increase= double.Parse(input);

                if (increase < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                sum += increase;
                Console.WriteLine($"Increase: {increase.ToString("0.00")}");
            }

            Console.WriteLine("Total: {0:F2}", sum);
        }
    }
}
