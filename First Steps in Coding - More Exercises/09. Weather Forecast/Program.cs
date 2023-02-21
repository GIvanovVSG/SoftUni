using System;

namespace _09._Weather_Forecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(Console.ReadLine() == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}
