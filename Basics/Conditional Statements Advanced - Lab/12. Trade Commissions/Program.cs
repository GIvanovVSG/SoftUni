using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission;

            if(sales >= 0 && sales <= 500)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = 5;
                        Console.WriteLine((sales * (commission * 0.010)).ToString("0.00"));
                        break;
                    case "Varna":
                        commission = 4.5;
                        Console.WriteLine((sales * (commission * 0.010)).ToString("0.00"));
                        break;
                    case "Plovdiv":
                        commission = 5.5;
                        Console.WriteLine((sales * (commission * 0.010)).ToString("0.00"));
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if(sales > 500 && sales <= 1000)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = 7;
                        Console.WriteLine((sales * (commission * 0.010)).ToString("0.00"));
                        break;
                    case "Varna":
                        commission = 7.5;
                        Console.WriteLine((sales * (commission * 0.010)).ToString("0.00"));
                        break;
                    case "Plovdiv":
                        commission = 8;
                        Console.WriteLine((sales * (commission * 0.010)).ToString("0.00"));
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if(sales > 1000 && sales <= 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = 8;
                        Console.WriteLine((sales * (commission * 0.010)).ToString("0.00"));
                        break;
                    case "Varna":
                        commission = 10;
                        Console.WriteLine((sales * (commission * 0.010)).ToString("0.00"));
                        break;
                    case "Plovdiv":
                        commission = 12;
                        Console.WriteLine((sales * (commission * 0.010)).ToString("0.00"));
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if(sales > 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = 12;
                        Console.WriteLine((sales * (commission * 0.010)).ToString("0.00"));
                        break;
                    case "Varna":
                        commission = 13;
                        Console.WriteLine((sales * (commission * 0.010)).ToString("0.00"));
                        break;
                    case "Plovdiv":
                        commission = 14.5;
                        Console.WriteLine((sales * (commission * 0.010)).ToString("0.00"));
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
