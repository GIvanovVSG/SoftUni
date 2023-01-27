using System;

namespace _01._Match_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peoples = int.Parse(Console.ReadLine());

            double vip = 499.99;
            double normal = 249.99;

            if (peoples >= 1 && peoples <= 4)
            {
                budget -= budget * 0.75;
            }
            else if (peoples >= 5 && peoples <= 9)
            {
                budget -= budget * 0.60;
            }
            else if (peoples >= 10 && peoples <= 24)
            {
                budget -= budget * 0.50;
            }
            else if (peoples >= 25 && peoples <= 49)
            {
                budget -= budget * 0.40;
            }
            else
            {
                budget -= budget * 0.25;
            }

            switch (category)
            {
                case "VIP":
                    if(budget >= peoples * vip)
                    {
                        Console.WriteLine($"Yes! You have {(budget - (peoples * vip)).ToString("0.00")} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {((peoples * vip) - budget).ToString("0.00")} leva.");
                    }
                    break;
                case "Normal":
                    if (budget >= peoples * normal)
                    {
                        Console.WriteLine($"Yes! You have {(budget - (peoples * normal)).ToString("0.00")} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {((peoples * normal) - budget).ToString("0.00")} leva.");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
