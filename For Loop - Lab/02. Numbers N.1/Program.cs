using System;

namespace _02._Numbers_N._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n >= 1)
            {
                Console.WriteLine(n);
                n--;
            }
        }
    }
}
