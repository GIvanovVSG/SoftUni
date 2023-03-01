using System;

namespace _03._Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vineyardSqMeters = double.Parse(Console.ReadLine()) * 0.4;
            double grapePerSqMeter = (double.Parse(Console.ReadLine()) * vineyardSqMeters);
            double neededWine = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            double wine = grapePerSqMeter / 2.5;

            if(wine < neededWine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Truncate(neededWine - wine)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Truncate(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wine - neededWine)} liters left -> {Math.Ceiling((wine - neededWine) / workers)} liters per person.");
            }
        }
    }
}
