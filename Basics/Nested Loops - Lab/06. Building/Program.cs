using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            int floorsQuantity = floors;

            for (int i = 1; i <= floorsQuantity; i++)
            {
                if (floorsQuantity % 2 == 0)
                {
                    if (i % 2 == 1)
                    {

                        for (int j = 0; j < rooms; j++)
                        {
                            if (j == 0 && i == 1)
                            {
                                for (int l = 0; l < rooms; l++)
                                {
                                    Console.Write($"L{floors}{l} ");
                                }
                                Console.WriteLine();
                                floors--;
                            }
                            else
                            {
                                for (int m = 0; m < rooms; m++)
                                {
                                    Console.Write($"O{floors}{m} ");
                                }
                                Console.WriteLine();
                                floors--;
                            }
                            break;
                        }
                    }
                    else
                    {
                        for (int m = 0; m < rooms; m++)
                        {
                            Console.Write($"A{floors}{m} ");
                        }
                        Console.WriteLine();
                        floors--;
                    }
                }
                else
                {
                    if (i % 2 == 1)
                    {

                        for (int j = 0; j < rooms; j++)
                        {
                            if (j == 0 && i == 1)
                            {
                                for (int l = 0; l < rooms; l++)
                                {
                                    Console.Write($"L{floors}{l} ");
                                }
                                Console.WriteLine();
                                floors--;
                            }
                            else
                            {
                                for (int m = 0; m < rooms; m++)
                                {
                                    Console.Write($"A{floors}{m} ");
                                }
                                Console.WriteLine();
                                floors--;
                            }
                            break;
                        }
                    }
                    else
                    {
                        for (int m = 0; m < rooms; m++)
                        {
                            Console.Write($"O{floors}{m} ");
                        }
                        Console.WriteLine();
                        floors--;
                    }
                }
            }
        }
    }
}
