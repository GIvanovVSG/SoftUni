using System;

namespace _03._Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemumQuantity = int.Parse(Console.ReadLine());
            int rosesQuantity = int.Parse(Console.ReadLine());
            int tulipsQuantity = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            double chrysanthemumPrice = 0;
            double rosesPrice = 0;
            double tulipsPrice = 0;


            switch (season)
            {
                case "Spring":
                case "Summer":
                    chrysanthemumPrice = 2.00;
                    rosesPrice = 4.10;
                    tulipsPrice = 2.50;
                    break;
                case "Autumn":
                case "Winter":
                    chrysanthemumPrice = 3.75;
                    rosesPrice = 4.50;
                    tulipsPrice = 4.15;
                    break;
                default:
                    break;
            }

            if (holiday == "Y")
            {
                chrysanthemumPrice += chrysanthemumPrice * 0.15;
                rosesPrice += rosesPrice * 0.15;
                tulipsPrice += tulipsPrice * 0.15;
            }

            double bouquet = (chrysanthemumQuantity * chrysanthemumPrice) + (rosesQuantity * rosesPrice) + (tulipsQuantity * tulipsPrice);

            if (tulipsQuantity > 7 && season == "Spring")
            {
                bouquet -= bouquet * 0.05;
            }

            if (rosesQuantity >= 10 && season == "Winter")
            {
                bouquet -= bouquet * 0.10;
            }

            if (chrysanthemumQuantity + rosesQuantity + tulipsQuantity > 20)
            {
                bouquet -= bouquet * 0.20;
            }

            Console.WriteLine((2 + bouquet).ToString("0.00"));

        }
    }
}
