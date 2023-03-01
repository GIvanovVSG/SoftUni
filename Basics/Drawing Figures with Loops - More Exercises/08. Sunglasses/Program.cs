using System;

namespace _08._Sunglasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if(i == 1 || i == n)
                {
                    Console.Write(new string('*', 2 * n));
                    Console.Write(new string(' ', n));
                    Console.Write(new string('*', 2 * n));
                }
                else
                {
                    if (n % 2 == 0 && i == n / 2)
                    {
                        Console.Write('*');
                        Console.Write(new string('/', (2 * n) - 2));
                        Console.Write('*');
                        Console.Write(new string('|', n));
                        Console.Write('*');
                        Console.Write(new string('/', (2 * n) - 2));
                        Console.Write('*');
                    }
                    else if (n % 2 == 1 && (n + 1)/ 2 == i )
                    {
                        Console.Write('*');
                        Console.Write(new string('/', (2 * n) - 2));
                        Console.Write('*');
                        Console.Write(new string('|', n));
                        Console.Write('*');
                        Console.Write(new string('/', (2 * n) - 2));
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('*');
                        Console.Write(new string('/', (2 * n) - 2));
                        Console.Write('*');
                        Console.Write(new string(' ', n));
                        Console.Write('*');
                        Console.Write(new string('/', (2 * n) - 2));
                        Console.Write('*');
                    }
                }

                    Console.WriteLine();
            }
        }
    }
}
