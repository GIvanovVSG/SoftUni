using System;
using System.Collections.Immutable;
using System.Linq;

namespace _02._Half_Sum_Element
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

            int maxValue = numbers.Max();
            int sum = numbers.Sum() - maxValue;


            if (maxValue == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxValue}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - maxValue)}");
            }
        }
    }
}
