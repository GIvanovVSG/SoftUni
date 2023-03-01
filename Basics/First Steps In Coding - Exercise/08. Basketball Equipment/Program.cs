using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double basketTax = double.Parse(Console.ReadLine());
            double basketShoes = basketTax - (basketTax * 0.40);
            double basketOutfit = basketShoes - (basketShoes * 0.20);
            double basketBall = basketOutfit / 4;
            double basketAccesoaries = basketBall / 5;

            Console.WriteLine(basketTax + basketShoes + basketOutfit + basketBall + basketAccesoaries);
        }
    }
}
