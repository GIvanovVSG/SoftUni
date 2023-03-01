using System;
using System.Security.Cryptography.X509Certificates;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            double judges = double.Parse(Console.ReadLine());

            double sum = 0;
            double sumPoints = 0;

            for (int i = 0; i < judges; i++)
            {
                string judgeName = Console.ReadLine();
                double judgePoints = double.Parse(Console.ReadLine());

                sum += (judgeName.Length * judgePoints) / 2;
                sumPoints = sum + academyPoints;

                if (sumPoints >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {sumPoints.ToString("0.0")}!");
                    return;
                }
            }

            Console.WriteLine($"Sorry, {actorName} you need {(1250.5 - sumPoints).ToString("0.0")} more!");
        }
    }
}
