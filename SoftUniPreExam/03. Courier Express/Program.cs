using System;

namespace _03._Courier_Express
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double packetWeight = double.Parse(Console.ReadLine());
            string serviceType = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine());
            double price = 0;

            if (serviceType == "standard")
            {
                if (packetWeight < 1)
                    price += kilometers * 0.03;
                else if (packetWeight >= 1 && packetWeight < 10)
                    price += kilometers * 0.05;
                else if (packetWeight >= 10 && packetWeight < 40)
                    price += kilometers * 0.10;
                else if (packetWeight >= 40 && packetWeight < 90)
                    price += kilometers * 0.15;
                else if (packetWeight >= 90 && packetWeight <= 150)
                    price += kilometers * 0.20;
            }
            else if (serviceType == "express")
            {
                if (packetWeight < 1)
                {
                    price += kilometers * 0.03;
                    price += (packetWeight * (0.15 * 0.80)) * kilometers;
                }
                else if (packetWeight >= 1 && packetWeight < 10)
                {
                    price += kilometers * 0.05;
                    price += (packetWeight * (0.15 * 0.40)) * kilometers;
                }
                else if (packetWeight >= 10 && packetWeight < 40)
                {
                    price += kilometers * 0.10;
                    price += (packetWeight * (0.15 * 0.05)) * kilometers;
                }
                else if (packetWeight >= 40 && packetWeight < 90)
                {
                    price += kilometers * 0.15;
                    price += (packetWeight * (0.15 * 0.02)) * kilometers;
                }
                else if (packetWeight >= 90 && packetWeight <= 150)
                {
                    price += kilometers * 0.20;
                    price += (packetWeight * (0.15 * 0.01)) * kilometers;
                }
            }

            Console.WriteLine($"The delivery of your shipment with weight of {packetWeight:F3} kg. would cost {price:F2} lv.");
        }
    }
}
