using System;

namespace _02._Report_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            string end;
            int transaction;
            int cashCount = 0;
            int cardCount = 0;
            double cash = 0;
            double card = 0;
            int count = 0;

            while ((end = Console.ReadLine()) != "End")
            {
                transaction = int.Parse(end);
                count++;

                if (count % 2 == 1)
                {
                    if (transaction > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        cash += transaction;
                        cashCount++;
                    }
                }
                else
                {
                    if (transaction < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        card += transaction;
                        cardCount++;
                    }
                }

                if (sum <= cash + card)
                {
                    Console.WriteLine($"Average CS: {(cash / cashCount).ToString("0.00")}");
                    Console.WriteLine($"Average CC: {(card / cardCount).ToString("0.00")}");
                    break;
                }
            }


            if (end == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
