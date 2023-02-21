using System;

namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pricePerMeter = 7.61;

            double squareMeters = double.Parse(Console.ReadLine());

            double totalPrice = pricePerMeter * squareMeters;
            double discount = 0.18 * totalPrice;
            double priceWithDiscount = totalPrice - discount;

            Console.WriteLine($"The final price is: {priceWithDiscount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
