using System;

namespace _01._Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine()) * 750;
            int dish = 5;
            int pot = 15;
            string end;
            int quantity;
            int washTimes = 0;
            int cleanDishes = 0;
            int cleanPots = 0;

            while ((end = Console.ReadLine()) != "End")
            {
                quantity = int.Parse(end);
                washTimes++;

                if(washTimes == 3)
                {
                    bottles -= quantity * pot;
                    washTimes = 0;
                    cleanPots += quantity;
                }
                else
                {
                    bottles-= quantity * dish;
                    cleanDishes += quantity;
                }

                if(bottles < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(bottles)} ml. more necessary!");
                    break;
                }
            }

            if(end == "End")
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{cleanDishes} dishes and {cleanPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {bottles} ml.");
            }
        }
    }
}
