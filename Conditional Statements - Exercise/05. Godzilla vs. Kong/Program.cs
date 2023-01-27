using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double extras = double.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine()) * extras;

            double decor = budget / 10;

            if(extras > 150)
            {
                clothesPrice -= clothesPrice / 10;
            }

            if(decor + clothesPrice > budget)
            {
                Console.WriteLine("Not enough money!");
                double result = (decor + clothesPrice) - budget;
                Console.WriteLine($"Wingard needs {result.ToString("0.00")} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                double result = budget - (decor + clothesPrice);
                Console.WriteLine($"Wingard starts filming with {result.ToString("0.00")} leva left.");
            }
        }
    }
}
