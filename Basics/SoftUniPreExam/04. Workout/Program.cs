using System;

namespace _04._Workout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double kilometers = double.Parse(Console.ReadLine());
            double allKilometers = kilometers;

            for (int i = 1; i <= days; i++)
            {
                double percents = double.Parse(Console.ReadLine());

                kilometers += kilometers * (percents / 100);
                allKilometers += kilometers;
            }

            if(allKilometers >= 1000)
                Console.WriteLine($"You've done a great job running {Math.Ceiling(allKilometers - 1000)} more kilometers!");
            else
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - allKilometers)} more kilometers");
        }
    }
}
