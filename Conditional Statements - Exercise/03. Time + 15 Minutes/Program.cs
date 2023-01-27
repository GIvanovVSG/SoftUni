using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes >= 45 && hours != 23)
            {
                hours += 1;
                minutes -= 45;
                Console.Write(hours);
                Console.Write(":");
                Console.Write("{0:D2}", minutes % 60);
            }
            else if(hours == 23 && minutes >= 45)
            {
                hours = 0;
                minutes -= 45;
                Console.Write(hours);
                Console.Write(":");
                Console.Write("{0:D2}", minutes % 60);
            }
            else if(minutes < 45 && hours != 23)
            {
                Console.Write(hours);
                Console.Write(":");
                Console.Write("{0:D2}", (minutes % 60)+ 15);
            }
            else
            {
                Console.Write(hours);
                Console.Write(":");
                Console.Write("{0:D2}", minutes % 60 + 15);
            }
        }
    }
}
