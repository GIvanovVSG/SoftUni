using System;

namespace _06._Truck_Driver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            int km = int.Parse(Console.ReadLine());

            double pricePerKm = 0;

            if(km <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        pricePerKm = 0.75;
                        break;
                    case "Summer":
                        pricePerKm = 0.90;
                        break;
                    case "Winter":
                        pricePerKm = 1.05;
                        break;
                    default:
                        break;
                }
            }
            else if (km > 5000 && km <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        pricePerKm = 0.95;
                        break;
                    case "Summer":
                        pricePerKm = 1.10;
                        break;
                    case "Winter":
                        pricePerKm = 1.25;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                pricePerKm = 1.45;
            }

            double salary = (((pricePerKm * km) * 4)) - ((pricePerKm * km) * 4) * 0.10 ;

            Console.WriteLine(salary.ToString("0.00"));
        }
    }
}
