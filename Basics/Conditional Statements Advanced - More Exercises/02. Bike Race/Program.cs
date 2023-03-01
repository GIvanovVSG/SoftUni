using System;

namespace _02._Bike_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniorBikers = int.Parse(Console.ReadLine());
            int seniorBikers = int.Parse(Console.ReadLine());
            string race = Console.ReadLine();

            double juniorTax = 0.0;
            double seniorTax = 0.0;

            switch (race)
            {
                case "trail":
                    juniorTax = 5.50;
                    seniorTax = 7;
                    break;
                case "cross-country":
                    juniorTax = 8;
                    seniorTax = 9.50;
                    break;
                case "downhill":
                    juniorTax = 12.25;
                    seniorTax = 13.75;
                    break;
                case "road":
                    juniorTax = 20;
                    seniorTax = 21.50;
                    break;
                default:
                    break;
            }

            if(race == "cross-country" && juniorBikers + seniorBikers >= 50)
            {
                juniorTax -= juniorTax * 0.25;
                seniorTax -= seniorTax * 0.25;
            }

            Console.WriteLine($"{(((juniorTax * juniorBikers) + (seniorTax * seniorBikers)) - (((juniorTax * juniorBikers) + (seniorTax * seniorBikers)) * 0.05)).ToString("0.00")}");
        }
    }
}
