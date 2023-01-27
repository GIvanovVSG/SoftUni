using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double puzzlePrice = 2.60;
            double dollPrice = 3;
            double teddyBearPrice = 4.10;
            double minion = 8.20;
            double truck = 2;

            double tripPrice = double.Parse(Console.ReadLine());
            double puzzlesQuantity = double.Parse(Console.ReadLine());
            double dollsQuantity = double.Parse(Console.ReadLine());
            double teddyBearsQuantity = double.Parse(Console.ReadLine());
            double minionsQuantity = double.Parse(Console.ReadLine());
            double trucksQuantity = double.Parse(Console.ReadLine());

            double toys = puzzlesQuantity + dollsQuantity + teddyBearsQuantity + minionsQuantity + trucksQuantity;
            double purchase = (puzzlesQuantity * puzzlePrice) + (dollsQuantity * dollPrice) + (teddyBearsQuantity * teddyBearPrice)
                + (minionsQuantity * minion) + (trucksQuantity * truck);

            if (toys >= 50)
            {
                purchase -= purchase / 4;
            }
            
            double rent = purchase / 10;
            double profit = purchase - rent;

            if(profit >= tripPrice)
            {
                double result = profit - tripPrice;
                Console.WriteLine($"Yes! {result.ToString("0.00")} lv left.");
            }
            else
            {
                double result = tripPrice- profit;
                Console.WriteLine($"Not enough money! {result.ToString("0.00")} lv needed.");
            }
        }
    }
}
