using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dogFoodPrice = 2.50;
            double catFoodPrice = 4.00;

            double dogFoodQuantity = double.Parse(Console.ReadLine());
            double catFoodQuantity = double.Parse(Console.ReadLine());

            double result = (dogFoodQuantity * dogFoodPrice) + (catFoodQuantity * catFoodPrice);

            Console.WriteLine($"{result} lv.");
        }
    }
}
