using System;

namespace _10._Clock___part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = 0;
            int minutes = 0;
            int seconds = 0;

            for (int h = 0; h < 24; h++)
            {
                for (int m = 0; m < 60; m++)
                {
                    for (int s = 0; s < 60; s++)
                    {
                        Console.WriteLine($"{hours} : {minutes} : {seconds}");
                        seconds++;
                        if(seconds == 60)
                        {
                            seconds = 0;
                        }
                    }
                        minutes++;
                        if (minutes == 60)
                        {
                            minutes = 0;
                        }
                }
                hours++;
            }
        }
    }
}
