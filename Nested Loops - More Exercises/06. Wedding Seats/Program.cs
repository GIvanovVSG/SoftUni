using System;
using System.Text;

namespace _06._Wedding_Seats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            int seats = int.Parse(Console.ReadLine());
            int count = 0;

            for (char sector = 'A'; sector <= lastSector; sector++)
            {
                for (int row = 1; row <= rows; row++)
                {
                    if(row % 2 == 0)
                    {
                        for (int seat = 1; seat <= seats + 2; seat++)
                        {
                            Console.WriteLine($"{sector}{row}{Convert.ToChar(seat + 96)}");
                            count++;
                        }
                    }
                    else
                    {
                        for (int seat = 1; seat <= seats; seat++)
                        {
                            Console.WriteLine($"{sector}{row}{Convert.ToChar(seat + 96)}");
                            count++;
                        }
                    }
                    
                }
                rows++;
            }

            Console.WriteLine(count);
        }
    }
}
