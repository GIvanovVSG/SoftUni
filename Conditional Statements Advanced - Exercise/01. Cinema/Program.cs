using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double premierePrice = 12.00;
            double normalPrice = 7.50;
            double discountPrice = 5.00;

            switch (projectionType)
            {
                case "Premiere":
                    Console.WriteLine($"\"{(premierePrice * (rows * columns)).ToString("0.00")} leva\", income");
                    break;
                case "Normal":
                    Console.WriteLine($"\"{(normalPrice * (rows * columns)).ToString("0.00")} leva\", income");
                    break;
                case "Discount":
                    Console.WriteLine($"\"{(discountPrice * (rows * columns)).ToString("0.00")} leva\", income");
                    break;
                default:
                    break;
            }
        }
    }
}
