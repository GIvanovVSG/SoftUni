using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int primeSum = 0;
            int nonPrimeSum = 0;

            while ((input = Console.ReadLine()) != "stop")
            {
                int number = int.Parse(input);

                if (number > 2 && number % 2 == 0 || number > 3 && number % 3 == 0)
                {
                    nonPrimeSum += number;
                }
                else if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    primeSum += number;
                }

            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
