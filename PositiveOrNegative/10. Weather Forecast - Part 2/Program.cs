using System;

namespace _10._Weather_Forecast___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number >= 26.00 && number <= 35.00)
            {
                Console.WriteLine("Hot");
            }
            else if (number >= 20.1 && number <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (number >= 15.00 && number <= 20.00)
            {
                Console.WriteLine("Mild");
            }
            else if(number >= 12.00 && number <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if(number >= 5.00 && number <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
