using System;

namespace _01._Pipes_In_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double poolVolume = double.Parse(Console.ReadLine());
            double pipeOne = double.Parse(Console.ReadLine());
            double pipeTwo = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double pipeOneSum = pipeOne * hours;
            double pipeTwoSum = pipeTwo * hours;
            double pipesSum = pipeOneSum + pipeTwoSum;

            if(pipesSum <= poolVolume)
            {
                double percentPool = (pipesSum / poolVolume) * 100;
                double percentPipeOne = (pipeOneSum / pipesSum) * 100;
                double percentPipeTwo = (pipeTwoSum / pipesSum) * 100;

                Console.WriteLine($"The pool is {percentPool.ToString("0.00")}% full. Pipe 1: {percentPipeOne.ToString("0.00")}%. " +
                    $"Pipe 2: {percentPipeTwo.ToString("0.00")}%.");
            }
            else
            {
                double overFlow = pipesSum - poolVolume;
                Console.WriteLine($"For {hours.ToString("0.00")} hours the pool overflows with {overFlow.ToString("0.00")} liters.");
            }
        }
    }
}

