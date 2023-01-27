using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double tripPrice = 0.0;
            string destination = "";
            string place = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        tripPrice = budget * 0.30;
                        place = "Camp";
                        break;
                    case "winter":
                        tripPrice = budget * 0.70;
                        place = "Hotel";
                        break;
                    default:
                        break;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        tripPrice = budget * 0.40;
                        place = "Camp";
                        break;
                    case "winter":
                        tripPrice = budget * 0.80;
                        place = "Hotel";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                destination = "Europe";
                place = "Hotel";
                tripPrice = budget * 0.90;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {tripPrice.ToString("0.00")}");
        }
    }
}
