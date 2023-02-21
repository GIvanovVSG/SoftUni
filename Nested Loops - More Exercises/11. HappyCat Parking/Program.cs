using System;

namespace _11._HappyCat_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double tax = 0;
            double finalPrice = 0;

            for (int i = 1; i <= days; i++)
            {
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 == 1)
                        tax += 2.50;
                    else if (i % 2 == 1 && j % 2 == 0)
                        tax += 1.25;
                    else
                        tax += 1;
                }
                Console.WriteLine($"Day: {i} - {tax:F2} leva");
                finalPrice += tax;
                tax = 0;

                if (i == days)
                    Console.WriteLine($"Total: {finalPrice:F2} leva");
            }
        }
    }
}
