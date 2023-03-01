using System;

namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumEven = 0;
            int sumOdd = 0;

            if(n != 1)
            {
                for (int i = 1; i < n; i += 2)
                {
                    if (n % 2 == 1 && i == 1)
                    {
                        int numOdd2 = int.Parse(Console.ReadLine());

                        sumOdd += numOdd2;
                    }

                    int numEven = int.Parse(Console.ReadLine());
                    int numOdd = int.Parse(Console.ReadLine());
                    sumEven += numEven;
                    sumOdd += numOdd;

                }
            }
            else
            {
                if (n == 1)
                {
                    int numOdd2 = int.Parse(Console.ReadLine());

                    sumOdd += numOdd2;
                }
            }

            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumEven}");
            }
            else if (n % 2 == 1)
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumEven - sumOdd)}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumEven - sumOdd)}");
            }
        }
    }
}
