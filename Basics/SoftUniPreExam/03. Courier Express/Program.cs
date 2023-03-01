using System;

namespace _03._Courier_Express
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string serviceType = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine());
            double price = 0;

            if (weight < 1)
                price += kilometers * 0.03;
            else if (weight >= 1 && weight < 10)
                price += kilometers * 0.05;
            else if (weight >= 10 && weight < 40)
                price += kilometers * 0.10;
            else if (weight >= 40 && weight < 90)
                price += kilometers * 0.15;
            else if (weight >= 90 && weight <= 150)
                price += kilometers * 0.20;

            if (serviceType == "express")
            {
                if (weight < 1)
                    price += (weight * (0.03 * 0.80)) * kilometers;
                else if (weight >= 1 && weight < 10)
                    price += (weight * (0.05 * 0.40)) * kilometers;
                else if (weight >= 10 && weight < 40)
                    price += (weight * (0.10 * 0.05)) * kilometers;
                else if (weight >= 40 && weight < 90)
                    price += (weight * (0.15 * 0.02)) * kilometers;
                else if (weight >= 90 && weight <= 150)
                    price += (weight * (0.20 * 0.01)) * kilometers;
            }

            Console.WriteLine($"The delivery of your shipment with weight of {weight:F3} kg. would cost {price:F2} lv.");
        }
    }
}
