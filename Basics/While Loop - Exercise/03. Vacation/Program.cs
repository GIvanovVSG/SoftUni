using System;
namespace ConditionalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeededForTrip = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            int days = 0;
            int spentDays = 0;

            while (true)
            {
                string saveOrSpend = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                days++;
                if (saveOrSpend == "save")
                {
                    budget += money;
                    spentDays = 0;
                }
                else if (saveOrSpend == "spend") 
                {
                    budget -= money;
                    spentDays++;
                }
                if (budget < 0)
                {
                    budget = 0;
                }
                if (spentDays == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{days}");
                    break;
                }
                else if (budget >= moneyNeededForTrip)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }
            }
        }
    }
}

