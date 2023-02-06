using System;

namespace _01._Back_To_The_Past
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            for (int i = 1800; i <= year; i++)
            {
                if(i % 2 ==0)
                {
                    money -= 12000;
                }
                else
                {
                    money -= 12000 + (50 * ((i - 1800) + 18));
                }
            }

            if(money >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money.ToString("0.00")} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(money).ToString("0.00")} dollars to survive.");
            }
        }
    }
}