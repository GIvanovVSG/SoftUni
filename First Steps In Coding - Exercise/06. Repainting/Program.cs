using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double naylonPerMeterPrice = 1.50;
            double paintLt = 14.50;
            double paintThinner = 5.00;
            double bags = 0.40;

            double naylonQuantity = double.Parse(Console.ReadLine()) * naylonPerMeterPrice;
            double paintQuantity = double.Parse(Console.ReadLine()) * paintLt;
            double paintThinnerQuantity = double.Parse(Console.ReadLine()) * paintThinner;
            double workingHours = double.Parse(Console.ReadLine());

            double priceForProducts = naylonQuantity + (naylonPerMeterPrice * 2) + (paintQuantity +
                (paintQuantity / 10)) + paintThinnerQuantity + bags;

            double sumForWorkers = ((priceForProducts / 10) * 3) * 8;

            Console.WriteLine(priceForProducts + sumForWorkers);
        }
    }
}
