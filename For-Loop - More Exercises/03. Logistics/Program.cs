using System;

namespace _03._Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weightQuantity = int.Parse(Console.ReadLine());

            double priceBus = 200;
            double priceTruck = 175;
            double priceTrain = 120;
            double price = 0;
            double countBus = 0;
            double countTruck = 0;
            double countTrain = 0;
            int allWeights = 0;

            for (int i = 0; i < weightQuantity; i++)
            {
                int weight = int.Parse(Console.ReadLine());

                if(weight <= 3)
                {
                    price += priceBus * weight;
                    countBus += weight;
                    allWeights += weight;
                }
                else if(weight <= 11)
                {
                    price += priceTruck * weight;
                    countTruck += weight;
                    allWeights += weight;
                }
                else
                {
                    price += priceTrain * weight;
                    countTrain += weight;
                    allWeights += weight;
                }
            }

            Console.WriteLine((price / allWeights).ToString("0.00"));
            Console.WriteLine($"{((countBus / allWeights) * 100).ToString("0.00")}%");
            Console.WriteLine($"{((countTruck / allWeights) * 100).ToString("0.00")}%");
            Console.WriteLine($"{((countTrain / allWeights) * 100).ToString("0.00")}%");
        }
    }
}
