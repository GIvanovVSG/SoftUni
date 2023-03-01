using System;

namespace _02._Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double minutesForPlay = 30000;
            double holydays = double.Parse(Console.ReadLine());
            double workDayPlay = 63;
            double restDayPlay = 127;

            double workingDays = 365 - holydays;
            double timeForPlay = (workingDays * workDayPlay) + (holydays * restDayPlay);


            if(timeForPlay > minutesForPlay)
            {
                double aboveNorm = timeForPlay - minutesForPlay;
                int hoursAbove = (int)aboveNorm / 60;
                double minutesAbove = aboveNorm % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hoursAbove} hours and {minutesAbove} minutes more for play");
            }
            else
            {
                double underNorm = minutesForPlay - timeForPlay;
                int hoursUnder = (int)underNorm / 60;
                double minutesUnder = underNorm % 60;

                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hoursUnder} hours and {minutesUnder} minutes less for play");
            }
        }
    }
}
