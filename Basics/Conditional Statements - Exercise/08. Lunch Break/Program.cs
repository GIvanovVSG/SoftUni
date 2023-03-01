using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            double movieDuration = double.Parse(Console.ReadLine());
            double restDuration = double.Parse(Console.ReadLine());
            double timeForEat = restDuration / 8;
            double timeForRest = restDuration / 4;

            double timeForMovie = restDuration - (timeForEat + timeForRest);

            if(timeForMovie >= movieDuration)
            {
                double timeLeft = timeForMovie - movieDuration;
                Console.WriteLine($"You have enough time to watch {movieName} and left with {Math.Ceiling(timeLeft)} minutes free time.");
            }
            else
            {
                double timeNeeded = movieDuration - timeForMovie;
                Console.WriteLine($"You don't have enough time to watch {movieName}, you need {Math.Ceiling(timeNeeded)} more minutes.");
            }
        }
    }
}

