using System;

namespace _10._Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int evenDash = (n - 2) / 2;
            int evenStars = 2;
            int oddDash = (n - 1) / 2;
            int oddStars = 1;
            int mid = 0;

            if (n % 2 == 0)
            {
                for (int cols = 1; cols <= (n / 2); cols++)
                {
                    if (cols == 1)
                    {
                        Console.Write(new string('-', evenDash));
                        Console.Write(new string('*', evenStars));
                        Console.Write(new string('-', evenDash));
                    }
                    else
                    {
                        Console.Write(new string('-', evenDash));
                        Console.Write(new string('*', evenStars));
                        Console.Write(new string('-', mid));
                        Console.Write(new string('*', evenStars));
                        Console.Write(new string('-', evenDash));
                    }
                    mid += 2;
                    evenStars = 1;
                    evenDash--;
                    Console.WriteLine();
                }

                evenDash = 1;
                mid -= 4;


                for (int cols = 1; cols <= (n / 2) - 1; cols++)
                {
                    if (cols == (n / 2) - 1)
                    {
                        Console.Write(new string('-', evenDash));
                        Console.Write(new string('*', evenStars + 1));
                        Console.Write(new string('-', evenDash));
                    }
                    else
                    {
                        Console.Write(new string('-', evenDash));
                        Console.Write(new string('*', evenStars));
                        Console.Write(new string('-', mid));
                        Console.Write(new string('*', evenStars));
                        Console.Write(new string('-', evenDash));
                    }

                    mid -= 2;
                    evenDash++;
                    Console.WriteLine();
                }
            }
            else
            {
                

                for (int cols = 1; cols <= (n + 1) / 2; cols++)
                {
                    if (cols == 1)
                    {
                        Console.Write(new string('-', oddDash));
                        Console.Write(new string('*', oddStars));
                        Console.Write(new string('-', mid));
                        Console.Write(new string('-', oddDash));
                        
                    }
                    else
                    {
                        Console.Write(new string('-', oddDash));
                        Console.Write(new string('*', oddStars));
                        Console.Write(new string('-', mid - 1));
                        Console.Write(new string('*', oddStars));
                        Console.Write(new string('-', oddDash));
                    }
                    mid += 2;
                    oddDash--;
                    Console.WriteLine();
                }

                oddDash = 1;
                mid -= 5;

                for (int cols = 1; cols <= (n - 1) / 2; cols++)
                {
                    if (cols == (n - 1) / 2)
                    {
                        Console.Write(new string('-', oddDash));
                        Console.Write(new string('*', oddStars));
                        Console.Write(new string('-', oddDash));
                    }
                    else
                    {
                        Console.Write(new string('-', oddDash));
                        Console.Write(new string('*', oddStars));
                        Console.Write(new string('-', mid));
                        Console.Write(new string('*', oddStars));
                        Console.Write(new string('-', oddDash));
                    }

                    mid -= 2;
                    oddDash += 1;
                    Console.WriteLine();
                }
            }
        }
    }
}
