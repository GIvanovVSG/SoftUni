using System;

namespace _10._Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oneLv = int.Parse(Console.ReadLine());
            int twoLv = int.Parse(Console.ReadLine());
            int fiveLv = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= oneLv; i++)
            {
                for (int j = 0; j <= twoLv; j++)
                {
                    for (int k = 0; k <= fiveLv; k++)
                    {
                        if(i + (j * 2) + (k * 5) == sum)
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                    }
                }
            }
            
        }
    }
}
