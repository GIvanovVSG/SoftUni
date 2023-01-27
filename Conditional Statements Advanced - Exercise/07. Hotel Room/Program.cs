using System;
using System.Diagnostics.CodeAnalysis;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceStudio = 0.0;
            double priceApartment = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = 50;
                    priceApartment = 65;
                    break;
                case "June":
                case "September":
                    priceStudio = 75.20;
                    priceApartment = 68.70;
                    break;
                case "July":
                case "August":
                    priceStudio = 76;
                    priceApartment = 77;
                    break;
                default:
                    break;
            }

            if(nights > 7)
            {
                if(month == "May" || month =="October")
                {
                    if(nights > 7 && nights <= 14)
                    {
                        priceStudio -= priceStudio * 0.05;
                    }
                    else
                    {
                        priceStudio -= priceStudio * 0.30;
                    }
                }
                else
                {
                    if(month == "June" || month == "September")
                    {
                        priceStudio -= priceStudio * 0.20;
                    }
                }

                if(nights > 14)
                {
                    priceApartment -= priceApartment * 0.10;
                }
            }

            Console.WriteLine($"Apartment: {(priceApartment * nights).ToString("0.00")} lv.");
            Console.WriteLine($"Studio: {(priceStudio * nights).ToString("0.00")} lv.");
        }
    }
}
