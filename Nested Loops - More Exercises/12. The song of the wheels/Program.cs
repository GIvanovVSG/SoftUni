using System;

namespace _12._The_song_of_the_wheels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int count = 0;
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;

            
                for (int a = 1; a <= 9; a++)
                {
                    for (int b = 1; b <= 9; b++)
                    {
                        for (int c = 1; c <= 9; c++)
                        {
                            for (int d = 1; d <= 9; d++)
                            {
                                if (a < b && c > d && (a * b) + (c * d) == m)
                                {
                                    Console.Write($"{a}{b}{c}{d} ");
                                    count ++;

                                    if(count == 4)
                                    {
                                        num1 = a;
                                        num2 = b;
                                        num3 = c;
                                        num4 = d;
                                    }
                                }
                            }
                        }
                    }
                }
            Console.WriteLine();
            
            if(count >= 4)
                Console.WriteLine($"Password: {num1}{num2}{num3}{num4}");
            else
                Console.WriteLine("No!");
        }
    }
}
