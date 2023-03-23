using System;

namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            double sum = 0;

            while ((command = Console.ReadLine()) != "Start")
            {
                double coins = double.Parse(command);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                    sum += coins;
                else
                    Console.WriteLine($"Cannot accept {coins}");
            }

            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "Nuts")
                {
                    if (sum >= 2)
                    {
                        sum -= 2;
                        Console.WriteLine($"Purchased nuts");
                    }
                    else
                        Console.WriteLine("Sorry, not enough money");
                }
                else if (command == "Water")
                {
                    if (sum >= 0.7)
                    {
                        sum -= 0.7;
                        Console.WriteLine($"Purchased water");
                    }
                    else
                        Console.WriteLine("Sorry, not enough money");
                }
                else if(command == "Crisps")
                {
                    if (sum >= 1.5)
                    {
                        sum -= 1.5;
                        Console.WriteLine($"Purchased crisps");
                    }
                    else
                        Console.WriteLine("Sorry, not enough money");
                }
                else if(command == "Soda")
                {
                    if (sum >= 0.8)
                    {
                        sum -= 0.8;
                        Console.WriteLine($"Purchased soda");
                    }
                    else
                        Console.WriteLine("Sorry, not enough money");
                }
                else if(command == "Coke")
                {
                    if (sum >= 1)
                    {
                        sum -= 1;
                        Console.WriteLine($"Purchased coke");
                    }
                    else
                        Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }

            Console.WriteLine($"Change: {sum:F2}");
        }
    }
}
