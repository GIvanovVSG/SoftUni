using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            string goingHome;
            int stepsSum = 0;

            while ((goingHome = Console.ReadLine()) != "Going home")
            {
                steps = int.Parse(goingHome);
                stepsSum += steps;

                if(stepsSum >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsSum - 10000} steps over the goal!");
                    break;
                }
            }

            if(stepsSum < 10000)
            {
                
                steps = int.Parse(Console.ReadLine());
                stepsSum += steps;

                if(stepsSum > 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsSum - 10000} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{10000 - stepsSum} more steps to reach goal.");
                }
            }
        }
    }
}
