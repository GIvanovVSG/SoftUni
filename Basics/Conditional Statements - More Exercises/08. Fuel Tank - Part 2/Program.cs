using System;
using System.Diagnostics.CodeAnalysis;

namespace _08._Fuel_Tank___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gasoline = 2.22;
            double diesel = 2.33;
            double gas = 0.93;

            string fuelType = Console.ReadLine();
            double littersFuel = double.Parse(Console.ReadLine());
            string clubCart = Console.ReadLine();

            if(fuelType == "Gas" && clubCart == "Yes")
            {
                double sum = (gas - 0.08) * littersFuel;
                if(littersFuel >= 20 && littersFuel <= 25)
                {
                    sum -= sum * 0.08;
                }
                else if(littersFuel > 25)
                {
                    sum -= sum * 0.10;
                }
                Console.WriteLine($"{sum.ToString("0.00")} lv.");
            }
            else if(fuelType == "Gas" && clubCart == "No")
            {
                double sum = gas * littersFuel;
                if (littersFuel >= 20 && littersFuel <= 25)
                {
                    sum -= sum * 0.08;
                }
                else if (littersFuel > 25)
                {
                    sum -= sum * 0.10;
                }
                Console.WriteLine($"{sum.ToString("0.00")} lv.");
            }

            if (fuelType == "Gasoline" && clubCart == "Yes")
            {
                double sum = (gasoline - 0.18) * littersFuel;
                if (littersFuel >= 20 && littersFuel <= 25)
                {
                    sum -= sum * 0.08;
                }
                else if (littersFuel > 25)
                {
                    sum -= sum * 0.10;
                }
                Console.WriteLine($"{sum.ToString("0.00")} lv.");
            }
            else if (fuelType == "Gasoline" && clubCart == "No")
            {
                double sum = gasoline * littersFuel;
                if (littersFuel >= 20 && littersFuel <= 25)
                {
                    sum -= sum * 0.08;
                }
                else if (littersFuel > 25)
                {
                    sum -= sum * 0.10;
                }
                Console.WriteLine($"{sum.ToString("0.00")} lv.");
            }

            if (fuelType == "Diesel" && clubCart == "Yes")
            {
                double sum = (diesel - 0.12) * littersFuel;
                if (littersFuel >= 20 && littersFuel <= 25)
                {
                    sum -= sum * 0.08;
                }
                else if (littersFuel > 25)
                {
                    sum -= sum * 0.10;
                }
                Console.WriteLine($"{sum.ToString("0.00")} lv.");
            }
            else if (fuelType == "Diesel" && clubCart == "No")
            {
                double sum = diesel * littersFuel;
                if (littersFuel >= 20 && littersFuel <= 25)
                {
                    sum -= sum * 0.08;
                }
                else if (littersFuel > 25)
                {
                    sum -= sum * 0.10;
                }
                Console.WriteLine($"{sum.ToString("0.00")} lv.");
            }
        }
    }
}
