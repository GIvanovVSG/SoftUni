using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            double banana = 2.50;
                            Console.WriteLine((banana * quantity).ToString("0.00"));
                            break;
                        case "apple":
                            double apple = 1.20;
                            Console.WriteLine((apple * quantity).ToString("0.00"));
                            break;
                        case "orange":
                            double orange = 0.85;
                            Console.WriteLine((orange * quantity).ToString("0.00"));
                            break;
                        case "grapefruit":
                            double grapefruit = 1.45;
                            Console.WriteLine((grapefruit * quantity).ToString("0.00"));
                            break;
                        case "kiwi":
                            double kiwi = 2.70;
                            Console.WriteLine((kiwi * quantity).ToString(
                                ));
                            break;
                        case "pineapple":
                            double pineapple = 5.50;
                            Console.WriteLine((pineapple * quantity).ToString("0.00"));
                            break;
                        case "grapes":
                            double grapes = 3.85;
                            Console.WriteLine((grapes * quantity).ToString("0.00"));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            double banana = 2.70;
                            Console.WriteLine((banana * quantity).ToString("0.00"));
                            break;
                        case "apple":
                            double apple = 1.25;
                            Console.WriteLine((apple * quantity).ToString("0.00"));
                            break;
                        case "orange":
                            double orange = 0.90;
                            Console.WriteLine((orange * quantity).ToString("0.00"));
                            break;
                        case "grapefruit":
                            double grapefruit = 1.60;
                            Console.WriteLine((grapefruit * quantity).ToString("0.00"));
                            break;
                        case "kiwi":
                            double kiwi = 3.00;
                            Console.WriteLine((kiwi * quantity).ToString("0.00"));
                            break;
                        case "pineapple":
                            double pineapple = 5.60;
                            Console.WriteLine((pineapple * quantity).ToString("0.00"));
                            break;
                        case "grapes":
                            double grapes = 4.20;
                            Console.WriteLine((grapes * quantity).ToString("0.00"));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}