using System;

namespace _06._Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double waterBills = 20;
            double internetBills = 15;
            double waterPrice = 0;
            double internetPrice = 0;
            double electricityPrice = 0;
            double other = 0;

            for (int i = 0; i < months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                electricityPrice += electricity;
                other += (waterBills + (waterBills * 0.20)) + (internetBills + (internetBills * 0.20)) + (electricity + (electricity * 0.20));
                waterPrice += waterBills;
                internetPrice += internetBills;
            }

            Console.WriteLine($"Electricity: {electricityPrice.ToString("0.00")} lv");
            Console.WriteLine($"Water: {(waterBills * months).ToString("0.00")} lv");
            Console.WriteLine($"Internet: {(internetBills * months).ToString("0.00")} lv");
            Console.WriteLine($"Other: {(other).ToString("0.00")} lv");
            Console.WriteLine($"Average: {((waterPrice + electricityPrice + internetPrice + other) / months).ToString("0.00")} lv");
        }
    }
}
