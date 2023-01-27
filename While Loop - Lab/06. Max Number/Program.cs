using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            string stop;
            int maxNumber = int.MinValue;

            while((stop = Console.ReadLine()) != "Stop")
            {
                number = int.Parse(stop);

                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}
