using System;

namespace _09._House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenStars = 2;
            int oddStars = 1;
            int underscore = (n - 2) / 2;
            int oddUnderscore = (n - 1) / 2;

            if (n % 2 == 0)
            {

                for (int i = 1; i <= n / 2; i++)
                {
                    Console.Write(new string('-', underscore));
                    Console.Write(new string('*', evenStars));
                    Console.Write(new string('-', underscore));
                    Console.WriteLine();
                    evenStars += 2;
                    underscore -= 1;
                }
                for (int i = 1; i <= n / 2; i++)
                {
                    Console.Write("|");
                    Console.Write(new string('*', n - 2));
                    Console.Write("|");
                    Console.WriteLine();
                }

            }
            else
            {
                for (int i = 1; i <= (n + 1) / 2; i++)
                {
                    Console.Write(new string('-', oddUnderscore));
                    Console.Write(new string('*', oddStars));
                    Console.Write(new string('-', oddUnderscore));
                    Console.WriteLine();
                    oddStars += 2;
                    oddUnderscore -= 1;
                }
                for (int i = 1; i <= (n - 1) / 2; i++)
                {
                    Console.Write("|");
                    Console.Write(new string('*', n - 2));
                    Console.Write("|");
                    Console.WriteLine();
                }
            }
            
        }
    }
}
