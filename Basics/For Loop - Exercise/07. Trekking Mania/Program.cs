using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            double musalaSum = 0;
            double monblanSum = 0;
            double kilimanjaro = 0;
            double k2 = 0;
            double everest = 0;
            double allClimbers = 0;

            for (int i = 0; i < groups; i++)
            {
                int climbers = int.Parse(Console.ReadLine());

                if (climbers <= 5)
                {
                    musalaSum += climbers;
                }
                else if (climbers <= 12)
                {
                    monblanSum += climbers;
                }
                else if (climbers <= 25)
                {
                    kilimanjaro += climbers;
                }
                else if (climbers <= 40)
                {
                    k2 += climbers;
                }
                else
                {
                    everest += climbers;
                }

                allClimbers += climbers;
            }

            Console.WriteLine($"{((musalaSum / allClimbers) * 100).ToString("0.00")}%");
            Console.WriteLine($"{((monblanSum / allClimbers) * 100).ToString("0.00")}%");
            Console.WriteLine($"{((kilimanjaro / allClimbers) * 100).ToString("0.00")}%");
            Console.WriteLine($"{((k2 / allClimbers) * 100).ToString("0.00")}%");
            Console.WriteLine($"{((everest / allClimbers) * 100).ToString("0.00")}%");
        }
    }
}
