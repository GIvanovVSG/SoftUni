using System;

namespace _05._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = "";
            string place;
            double  price = 0;

            if(budget <= 1000)
            {
                place = "Camp";

                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        price = budget * 0.65;
                        break;
                    case "Winter":
                        location = "Morocco";
                        price = budget * 0.45;
                        break;
                    default:
                        break;
                }
            }
            else if(budget > 1000 && budget <= 3000)
            {
                place = "Hut";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        price = budget * 0.80;
                        break;
                    case "Winter":
                        location = "Morocco";
                        price = budget * 0.60;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                place = "Hotel";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        price = budget * 0.90;
                        break;
                    case "Winter":
                        location = "Morocco";
                        price = budget * 0.90;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"{location} - {place} - {price.ToString("0.00")}");
        }
    }
}
