using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherMans = int.Parse(Console.ReadLine());

            double priceOfSeason = 0.0;

            switch (season)
            {
                case "Spring":
                    priceOfSeason = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    priceOfSeason = 4200;
                    break;
                case "Winter":
                    priceOfSeason = 2600;
                    break;
                default:
                    break;
            }

            if(fisherMans <= 6)
            {
                priceOfSeason -= priceOfSeason * 0.10;
            }
            else if(fisherMans >= 7 && fisherMans <= 11)
            {
                priceOfSeason -= priceOfSeason * 0.15;
            }
            else
            {
                priceOfSeason -= priceOfSeason * 0.25;
            }

            if(fisherMans % 2 == 0 && season != "Autumn")
            {
                priceOfSeason -= priceOfSeason * 0.05;
            }

            if(budget >= priceOfSeason)
            {
                Console.WriteLine($"Yes! You have {(budget - priceOfSeason).ToString("0.00")} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(priceOfSeason - budget).ToString("0.00")} leva.");
            }
        }
    }
}
