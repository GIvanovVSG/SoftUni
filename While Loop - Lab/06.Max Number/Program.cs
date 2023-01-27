using System;

namespace _07.Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            string stop;
            int minNumer = int.MaxValue;

            while ((stop = Console.ReadLine()) != "Stop")
            {
                number = int.Parse(stop);
                
                if (number < minNumer)
                {
                    minNumer = number;
                }

            }

            Console.WriteLine(minNumer);
        }
    }
}
