using System;

namespace _05._Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double wholeFood = double.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine()) * days;
            double catFoodPerDay = double.Parse(Console.ReadLine()) * days;
            double turtleFoodPerDay = (double.Parse(Console.ReadLine()) / 1000) * days;

            if (wholeFood >= dogFoodPerDay + catFoodPerDay + turtleFoodPerDay)
            {
                Console.WriteLine($"{Math.Truncate(wholeFood - (dogFoodPerDay + catFoodPerDay + turtleFoodPerDay))} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling((dogFoodPerDay + catFoodPerDay + turtleFoodPerDay) - wholeFood)} more kilos of food are needed.");
            }
        }
    }
}
