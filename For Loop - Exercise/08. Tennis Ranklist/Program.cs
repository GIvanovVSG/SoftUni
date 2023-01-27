using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournaments= int.Parse(Console.ReadLine());
            double startPoints = double.Parse(Console.ReadLine());

            double points = 0;
            double winTournaments = 0;

            for (int i = 0; i < tournaments; i++)
            {
                string stage = Console.ReadLine();

                switch (stage)
                {
                    case "W":
                        points += 2000;
                        winTournaments++;
                        break;
                    case "F":
                        points += 1200;
                        break;
                    case "SF":
                        points += 720;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Final points: {points + startPoints}");
            Console.WriteLine($"Average points: {Math.Truncate(points / tournaments)}");
            Console.WriteLine($"{((winTournaments / tournaments) * 100).ToString("0.00")}%");
        }
    }
}
