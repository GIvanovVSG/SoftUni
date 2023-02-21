using System;

namespace _08._Secret_Door_s_Lock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hundreads = int.Parse(Console.ReadLine());
            int dozens = int.Parse(Console.ReadLine());
            int singles = int.Parse(Console.ReadLine());

            for (int i = 1; i <= hundreads; i++)
            {
                if (i % 2 == 0)
                {
                    for (int k = 1; k <= dozens; k++)
                    {
                        if (k == 2 || k == 3 || k == 5 || k == 7)
                        {
                            for (int l = 1; l <= singles; l++)
                            {
                                if (l % 2 == 0)
                                {
                                    Console.Write($"{i} {k} {l}");
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
