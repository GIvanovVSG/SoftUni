using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal sum = decimal.Parse(Console.ReadLine());
            int coins = 0;


            while(sum != 0)
            {
                while(sum >= 2.00M)
                {
                    coins++;
                    sum -= 2.00M;
                }

                while(sum >= 1.00M)
                {
                    coins++;
                    sum -= 1.00M;
                }

                while (sum >= 0.50M)
                {
                    coins++;
                    sum -= 0.50M;
                }

                while (sum >= 0.20M)
                {
                    coins++;
                    sum -= 0.20M;
                }

                while (sum >= 0.10M)
                {
                    coins++;
                    sum -= 0.10M;
                }

                while (sum >= 0.05M)
                {
                    coins++;
                    sum -= 0.05M;
                }

                while (sum >= 0.02M)
                {
                    coins++;
                    sum -= 0.02M;
                }

                while (sum >= 0.01M)
                {
                    coins++;
                    sum -= 0.01M;
                }
            }

            Console.WriteLine(coins);
        }
    }
}
