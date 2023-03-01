using System;

namespace _05._Training_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hallHeightInCm = double.Parse(Console.ReadLine()) * 100;
            double hallWidthInCm = (double.Parse(Console.ReadLine()) * 100) - 100;

            int wWorkingPaces = (int)hallWidthInCm / 70;
            int hWorkingPlaces = (int)hallHeightInCm / 120;

            int hallWorkingPlaces = (wWorkingPaces * hWorkingPlaces) - 3;

            Console.WriteLine(hallWorkingPlaces);
        }
    }
}
