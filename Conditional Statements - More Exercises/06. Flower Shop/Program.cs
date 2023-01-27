using System;

namespace _06._Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double magnolias = double.Parse(Console.ReadLine()) * 3.25;
            double hyacinths = double.Parse(Console.ReadLine()) * 4;
            double roses = double.Parse(Console.ReadLine()) * 3.50;
            double cacti = double.Parse(Console.ReadLine()) * 8;
            double priceForAGift = double.Parse(Console.ReadLine());

            double sum = magnolias + hyacinths + roses + cacti;
            double sumWithTax = sum - (sum * 0.05);

            if (sumWithTax >= priceForAGift)
            {
                Console.WriteLine($"She is left with {Math.Truncate(sumWithTax - priceForAGift)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(priceForAGift - sumWithTax)} leva.");
            }
        }
    }
}
