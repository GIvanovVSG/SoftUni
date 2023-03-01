using System;

namespace _10._Multiply_by_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = 0;

            while (number >= 0)
            {
                double num = double.Parse(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("Negative number!");
                    return;
                }
                else
                {
                    Console.WriteLine($"Result: {(num * 2).ToString("0.00")}");
                    number = num;
                }
            }
        }
    }
}
