using System;

namespace _07._Football_League
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int fens = int.Parse(Console.ReadLine());

            double sectorA = 0;
            double sectorB = 0;
            double sectorV = 0;
            double sectorG = 0;

            for (int i = 0; i < fens; i++)
            {
                char sector = char.Parse(Console.ReadLine());

                switch (sector)
                {
                    case 'A':
                        sectorA++;
                        break;
                    case 'B':
                        sectorB++;
                        break;
                    case 'V':
                        sectorV++;
                        break;
                    case 'G':
                        sectorG++;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"{((sectorA / fens) * 100).ToString("0.00")}%");
            Console.WriteLine($"{((sectorB / fens) * 100).ToString("0.00")}%");
            Console.WriteLine($"{((sectorV / fens) * 100).ToString("0.00")}%");
            Console.WriteLine($"{((sectorG / fens) * 100).ToString("0.00")}%");
            Console.WriteLine($"{(((sectorA + sectorB + sectorV + sectorG) / capacity) * 100).ToString("0.00")}%");
        }
    }
}
