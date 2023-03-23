using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeoples = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            if (groupType == "Students")
            {
                switch (day)
                {
                    case "Friday":
                        price = 8.45;
                        break;
                    case "Saturday":
                        price = 9.80;
                        break;
                    case "Sunday":
                        price = 10.46;
                        break;
                    default:
                        break;
                }

                if(countOfPeoples >= 30)
                    price -= price * 0.15;
            }
            else if (groupType == "Business")
            {
                switch (day)
                {
                    case "Friday":
                        price = 10.90;
                        break;
                    case "Saturday":
                        price = 15.60;
                        break;
                    case "Sunday":
                        price = 16;
                        break;
                    default:
                        break;
                }

                if (countOfPeoples >= 100)
                    countOfPeoples -= 10;
            }
            else if (groupType == "Regular")
            {
                switch (day)
                {
                    case "Friday":
                        price = 15;
                        break;
                    case "Saturday":
                        price = 20;
                        break;
                    case "Sunday":
                        price = 22.50;
                        break;
                    default:
                        break;
                }

                if (countOfPeoples >= 10 && countOfPeoples <= 20)
                    price -= price * 0.05;
            }

            Console.WriteLine($"Total price: {(price * countOfPeoples):F2}");
        }
    }
}
