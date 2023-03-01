using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double whirlpoolPrice = double.Parse(Console.ReadLine());
            double pricePerToy = double.Parse(Console.ReadLine());

            int toys = 0;
            int money = 0;
            int sumMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if(i % 2 == 1)
                {
                    toys++;
                }
                else
                {
                    money += 10;
                    sumMoney += money;
                }
            }

            double collectedMoney = ((toys * pricePerToy) + sumMoney) - age / 2;

            if(collectedMoney >= whirlpoolPrice)
            {
                Console.WriteLine($"Yes! {(collectedMoney - whirlpoolPrice).ToString("0.00")}");
            }
            else
            {
                Console.WriteLine($"No! {(whirlpoolPrice - collectedMoney).ToString("0.00")}");
            }
        }
    }
}
