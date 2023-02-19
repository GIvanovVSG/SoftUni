using System;

namespace _02._Maiden_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double partyPrice = double.Parse(Console.ReadLine());
            int loveMessagesQuantity = int.Parse(Console.ReadLine());
            int waxRoseQuantity = int.Parse(Console.ReadLine());
            int keyChainsQuantity = int.Parse(Console.ReadLine());
            int caricaturesQuantity = int.Parse(Console.ReadLine());
            int luckySurpricesQuantity = int.Parse(Console.ReadLine());

            double loveMessagePrice = 0.60;
            double waxRosePrice = 7.20;
            double keyChainPrice = 3.60;
            double caricaturePrice = 18.20;
            int luckySurpricePrice = 22;

            double sum = (loveMessagesQuantity * loveMessagePrice) + (waxRoseQuantity * waxRosePrice) + (keyChainsQuantity * keyChainPrice)
                + (caricaturesQuantity * caricaturePrice) + (luckySurpricesQuantity * luckySurpricePrice);
            double quantity = loveMessagesQuantity + waxRoseQuantity + keyChainsQuantity + caricaturesQuantity + luckySurpricesQuantity;

            if(quantity >= 25)
            {
                sum -= sum * 0.35;
            }

            sum -= sum * 0.10;

            if(sum >= partyPrice)
                Console.WriteLine($"Yes! {(sum - partyPrice):F2} lv left.");
            else
                Console.WriteLine($"Not enough money! {(partyPrice - sum):F2} lv needed.");
        }
    }
}
