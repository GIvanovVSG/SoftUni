using System;

namespace _14._Password_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int a = 1; a <= n; a++)
            {
                for (int b = 1; b <= n; b++)
                {
                    for (int c = 97; c <= l + 96; c++)
                    {
                        for (int d = 97; d <= l + 96; d++)
                        {
                            for (int e = 1; e <= n; e++)
                            {
                                if(e > a && e > b)
                                {
                                    Console.Write($"{a}{b}{Convert.ToChar(c)}{Convert.ToChar(d)}{e} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
