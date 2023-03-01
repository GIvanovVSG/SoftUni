using System;
using System.Buffers;
using System.Security.Cryptography.X509Certificates;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double rose = 5;
            const double dahlia = 3.80;
            const double tulip = 2.80;
            const double narcissus = 3;
            const double gladiola = 2.50;

            string flowers = Console.ReadLine();
            int flowersQuantity = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double price;


            if (flowersQuantity > 90 && flowers == "Dahlias" || flowersQuantity > 80 && flowers == "Tulips" || flowersQuantity > 80 && flowers == "Roses")
            {
                if (flowersQuantity > 90 && flowers == "Dahlias")
                {
                    price = flowersQuantity * dahlia;
                    price -= price * 0.15;
                }
                else if (flowers == "Tulips")
                {
                    price = flowersQuantity * tulip;
                    price -= price * 0.15;
                }
                else
                {
                    price = flowersQuantity * rose;
                    price -= price * 0.10;
                }

                OutputMethod();
            }
            else if (flowersQuantity < 120 && flowers == "Narcissus" || flowersQuantity < 80 && flowers == "Gladiolus")
            {
                if (flowers == "Narcissus")
                {
                    price = flowersQuantity * narcissus;
                    price += price * 0.15;
                }
                else
                {
                    price = flowersQuantity * gladiola;
                    price += price * 0.20;
                }

                OutputMethod();
            }
            else
            {
                switch (flowers)
                {
                    case "Dahlias":
                        price = flowersQuantity * dahlia;
                        OutputMethod();
                        break;
                    case "Tulips":
                        price = flowersQuantity * tulip;
                        OutputMethod();
                        break;
                    case "Roses":
                        price = flowersQuantity * rose;
                        OutputMethod();
                        break;
                    case "Narcissus":
                        price = flowersQuantity * narcissus;
                        OutputMethod();
                        break;
                    case "Gladiolus":
                        price = flowersQuantity * gladiola;
                        OutputMethod();
                        break;
                    default:
                        break;
                }
            }

            void OutputMethod()
            {
                if (budget >= price)
                {
                    Console.WriteLine($"Hey, you have a great garden with {flowersQuantity} {flowers} and {(budget - price).ToString("0.00")} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money, you need {(price - budget).ToString("0.00")} leva more.");
                }
            }
        }
    }
}
