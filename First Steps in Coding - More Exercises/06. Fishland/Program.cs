using System;

namespace _06._Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //цена на скумрията
            double priceMackerelKg = double.Parse(Console.ReadLine());
            //цена на цацата
            double priceSprinkleKg = double.Parse(Console.ReadLine());
            //килограми и цена паламуд
            double bonitoPriceKg = priceMackerelKg + (priceMackerelKg * 0.60);
            double sumBonito = double.Parse(Console.ReadLine()) * bonitoPriceKg;
            //килограми и цена сафрид
            double safridPriceKg = priceSprinkleKg + (priceSprinkleKg * 0.80);
            double sumSafrid = double.Parse(Console.ReadLine()) * safridPriceKg;
            //килограми и цена миди
            double musselsWeightInKg = double.Parse(Console.ReadLine()) * 7.50;

            Console.WriteLine("{0:F2}", sumBonito + sumSafrid + musselsWeightInKg);
        }
    }
}
