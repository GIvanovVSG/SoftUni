using System;

namespace Nums1To10
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerKgVegetables = double.Parse(Console.ReadLine());
            double pricePerKgFruits = double.Parse(Console.ReadLine());
            double kgVegetables = double.Parse(Console.ReadLine()) * pricePerKgVegetables;
            double kgFruits = double.Parse(Console.ReadLine()) * pricePerKgFruits;

            double price = (kgVegetables + kgFruits) / 1.94;

            Console.WriteLine("{0:F2}", price);
        }
    }
}