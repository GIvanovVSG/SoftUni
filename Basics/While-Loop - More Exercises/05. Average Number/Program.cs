using System;

namespace _05._Average_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            int count = 0;

            while (count < n)
            {
                count++;
                int number = int.Parse(Console.ReadLine());

                sum += number;
            }
            

            Console.WriteLine((sum / n).ToString("0.00"));
        }
    }
}
