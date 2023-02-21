using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pensPrice = 5.80;
            double markersPrice = 7.20;
            double detergentPrice = 1.20;


            double pensPackets = double.Parse(Console.ReadLine()) * pensPrice;
            double markersPackets = double.Parse(Console.ReadLine()) * markersPrice;
            double cleaningDetergents = double.Parse(Console.ReadLine()) * detergentPrice;
            double reduction = double.Parse(Console.ReadLine()) / 100;

            double sum = pensPackets + markersPackets + cleaningDetergents;
            double reductedSum = sum - (sum * reduction);
            Console.WriteLine(reductedSum);
        }
    }
}
