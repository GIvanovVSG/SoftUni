using System;

namespace _07._School_Camp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            double price = 0;
            string sport = "";

            switch (groupType)
            {
                case "boys":
                case "girls":
                    switch (season)
                    {
                        case "Winter":
                            price = 9.60;
                            break;
                        case "Spring":
                            price = 7.20;
                            break;
                        case "Summer":
                            price = 15;
                            break;
                        default:
                            break;
                    }
                    break;
                case "mixed":
                    switch (season)
                    {
                        case "Winter":
                            price = 10;
                            break;
                        case "Spring":
                            price = 9.50;
                            break;
                        case "Summer":
                            price = 20;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            if(students >= 50)
            {
                price -= price * 0.50;
            }
            else if (students >=20)
            {
                price -= price * 0.15;
            }
            else if(students >= 10)
            {
                price -= price * 0.05;
            }

            switch (groupType)
            {
                case "boys":
                    switch (season)
                    {
                        case "Winter":
                            sport = "Judo";
                            break;
                        case "Spring":
                            sport = "Tennis";
                            break;
                        case "Summer":
                            sport = "Football";
                            break;
                        default:
                            break;
                    }
                    break;
                case "girls":
                    switch (season)
                    {
                        case "Winter":
                            sport = "Gymnastics";
                            break;
                        case "Spring":
                            sport = "Athletics";
                            break;
                        case "Summer":
                            sport = "Volleyball";
                            break;
                        default:
                            break;
                    }
                    break;
                case "mixed":
                    switch (season)
                    {
                        case "Winter":
                            sport = "Ski";
                            break;
                        case "Spring":
                            sport = "Cycling";
                            break;
                        case "Summer":
                            sport = "Swimming";
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{sport} {((students * price) * nights).ToString("0.00")} lv.");
        }
    }
}
