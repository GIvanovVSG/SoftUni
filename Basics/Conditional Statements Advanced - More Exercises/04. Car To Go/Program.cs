using System;

namespace _04._Car_To_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string carClass;
            double carPrice = 0.0;
            string car = "";

            if(budget <= 100)
            {
                carClass = "Economy class";

                switch (season)
                {
                    case "Summer":
                        car = "Cabrio";
                        carPrice = budget * 0.35;
                        break;
                    case "Winter":
                        car = "Jeep";
                        carPrice = budget * 0.65;
                        break;
                    default:
                        break;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                carClass = "Compact class";

                switch (season)
                {
                    case "Summer":
                        car = "Cabrio";
                        carPrice = budget * 0.45;
                        break;
                    case "Winter":
                        car = "Jeep";
                        carPrice = budget * 0.80;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                carClass = "Luxury class";

                switch (season)
                {
                    case "Summer":
                    case "Winter":
                        car = "Jeep";
                        carPrice = budget * 0.90;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"{carClass}");
            Console.WriteLine($"{car} - {carPrice.ToString("0.00")}");
        }
    }
}
