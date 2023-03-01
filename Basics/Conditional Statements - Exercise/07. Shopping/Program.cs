using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double video = double.Parse(Console.ReadLine());
            double videoPrice = video * 250;
            double proc = double.Parse(Console.ReadLine());
            double procPrice = proc * (videoPrice * 0.35);
            double ram = double.Parse(Console.ReadLine()) * (videoPrice * 0.10);

            double sum = videoPrice + procPrice + ram;

            if (video > proc)
            {
                sum -= sum * 0.15;
            }

            if(budget >= sum)
            {
                double result = budget - (sum);
                Console.WriteLine($"You have {result.ToString("0.00")} leva left!");
            }
            else
            {
                double result = (sum) - budget;
                Console.WriteLine($"Not enough money! You need {result.ToString("0.00")} leva more!");
            }
        }
    }
}
