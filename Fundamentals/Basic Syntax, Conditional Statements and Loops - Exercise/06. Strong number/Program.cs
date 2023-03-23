using System;
using System.Diagnostics.CodeAnalysis;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numLenght = num.ToString().Length;
            int number = num;


            int digit;
            int factorial;
            int sum = 0;

            for (int i = 0; i < numLenght; i++)
            {
                digit = num % 10;
                factorial = 1;

                if (digit == 0)
                    sum += 1;

                for (int j = 1; j <= digit; j++)
                {
                    factorial *= j;
                    if(j == digit)
                    sum += factorial;
                }

                num /= 10;
            }

            
            if(number == sum)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
            
        }
    }
}
