using System;
using System.Linq;

namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                numbers[i] = input;
            }

            Console.WriteLine("Max number: " + numbers.Max());
            Console.WriteLine("Min number: " + numbers.Min());
        }
    }
}
