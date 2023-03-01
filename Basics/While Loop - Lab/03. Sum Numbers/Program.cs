using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumnumbers = 0;

            while (number > sumnumbers)
            {
                int nums = int.Parse(Console.ReadLine());
                sumnumbers += nums;
            }

            Console.WriteLine(sumnumbers);
        }
    }
}
