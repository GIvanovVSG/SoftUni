using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget;

            while (true)
            {
                string destination = Console.ReadLine();

                if (destination == "End")
                {
                    break;
                }

                budget = double.Parse(Console.ReadLine());
                double finalSum = 0;

                while (finalSum < budget)
                {
                    double sum = double.Parse(Console.ReadLine());
                    finalSum += sum;
                }

                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}