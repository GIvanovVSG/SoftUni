using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers < 200)
                {
                    p1++;
                }
                else if(numbers < 400)
                {
                    p2++;
                }
                else if(numbers < 600)
                {
                    p3++;
                }
                else if(numbers < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }

            double whole = p1 + p2 + p3 + p4 + p5;

            Console.WriteLine($"{((p1 / whole) * 100).ToString("0.00")}%");
            Console.WriteLine($"{((p2 / whole) * 100).ToString("0.00")}%");
            Console.WriteLine($"{((p3 / whole) * 100).ToString("0.00")}%");
            Console.WriteLine($"{((p4 / whole) * 100).ToString("0.00")}%");
            Console.WriteLine($"{((p5 / whole) * 100).ToString("0.00")}%");
        }
    }
}
