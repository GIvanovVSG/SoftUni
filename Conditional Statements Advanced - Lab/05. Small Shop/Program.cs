using System;

namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            decimal quantity = decimal.Parse(Console.ReadLine());

            if(product == "coffee")
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine(decimal.Round(0.50M * quantity, 1));
                        break;
                    case "Plovdiv":
                        Console.WriteLine(decimal.Round(0.40M * quantity, 1));
                        break;
                    case "Varna":
                        Console.WriteLine(decimal.Round(0.45M * quantity, 1));
                        break;
                    default:
                        break;
                }
            }
            else if (product == "water")
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine(decimal.Round(0.80M * quantity, 1));
                        break;
                    case "Plovdiv":
                        Console.WriteLine(decimal.Round(0.70M * quantity, 1));
                        break;
                    case "Varna":
                        Console.WriteLine(decimal.Round(0.70M * quantity, 1));
                        break;
                    default:
                        break;
                }
            }
            else if (product == "beer")
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine(decimal.Round(1.20M * quantity, 1));
                        break;
                    case "Plovdiv":
                        Console.WriteLine(decimal.Round(1.15M * quantity, 1));
                        break;
                    case "Varna":
                        Console.WriteLine(decimal.Round(1.10M * quantity, 1));
                        break;
                    default:
                        break;
                }
            }
            else if (product == "sweets")
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine(1.45M * quantity);
                        break;
                    case "Plovdiv":
                        Console.WriteLine(1.30M * quantity);
                        break;
                    case "Varna":
                        Console.WriteLine(1.35M * quantity);
                        break;
                    default:
                        break;
                }
            }
            else if (product == "peanuts")
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine(decimal.Round(1.60M * quantity, 1));
                        break;
                    case "Plovdiv":
                        Console.WriteLine(decimal.Round(1.50M * quantity, 1));
                        break;
                    case "Varna":
                        Console.WriteLine(decimal.Round(1.55M * quantity, 1));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
