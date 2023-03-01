using System;

namespace _04._Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kilometers = double.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double taxiAtDay = 0.79;
            double taxiAtNight = 0.90;

            double bus = 0.09;

            double train = 0.06;

            if (dayOrNight == "day" && kilometers < 20)
            {
                Console.WriteLine($"{((taxiAtDay * kilometers) + 0.70).ToString("0.00")}");
            }
            else if(dayOrNight == "night" && kilometers < 20)
            {
                Console.WriteLine($"{((taxiAtNight * kilometers) + 0.70).ToString("0.00")}");
            }
            else if (kilometers >= 20 && kilometers < 100 && dayOrNight == "day" || kilometers >= 20 && kilometers < 100 && dayOrNight == "night")
            {
                Console.WriteLine($"{(kilometers * bus).ToString("0.00")}");
            }
            else
            {
                Console.WriteLine($"{(kilometers * train).ToString("0.00")}");
            }
        }
    }
}
