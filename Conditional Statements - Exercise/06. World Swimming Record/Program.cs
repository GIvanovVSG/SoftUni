using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double timeForSwimming = distanceInMeters * timeForOneMeter;
            int del = (int)distanceInMeters / 15;
            double delay = del * 12.5;

            double ivanResult = timeForSwimming + delay;
            if (ivanResult < recordInSeconds)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {ivanResult.ToString("0.00")} seconds.");
            }
            else
            {
                double lackingSeconds = ivanResult - recordInSeconds;
                Console.WriteLine($"No, he failed! He was {lackingSeconds.ToString("0.00")} seconds slower.");
            }
        }
    }
}
