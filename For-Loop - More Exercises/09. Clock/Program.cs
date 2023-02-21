using System;

namespace _09._Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = 0;
            int minutes = 0;

            for (int h = 0; h < 24; h++)
            {
                for (int m = 0; m < 60; m++)
                {
                    Console.WriteLine($"{hours} : {minutes}");
                    minutes++;
                    if(minutes == 60)
                    {
                        minutes = 0;
                    }
                }
                    hours++;
            }
        }
    }
}
