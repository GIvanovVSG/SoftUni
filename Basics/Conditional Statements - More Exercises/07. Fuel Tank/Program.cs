using System;

namespace _07._Fuel_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double litters = double.Parse(Console.ReadLine());

            if(fuel == "Diesel" || fuel == "Gasoline" || fuel == "Gas")
            {
                if(litters>= 25)
                {
                    Console.WriteLine($"You have enough {fuel.ToLower()}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {fuel.ToLower()}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}