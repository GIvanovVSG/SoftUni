using System;

namespace _02._Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            string ourfit = "";
            string shoes = "";

            if(degrees >= 10 && degrees <= 18)
            {
                switch (time)
                {
                    case "Morning":
                        ourfit = "Sweatshirt";
                        shoes = "Sneakers";
                        break;
                    case "Afternoon":
                    case "Evening":
                        ourfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                    default:
                        break;
                }
            }
            else if(degrees > 18 && degrees <= 24)
            {
                switch (time)
                {
                    case "Morning":
                    case "Evening":
                        ourfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                    case "Afternoon":
                        ourfit = "T-Shirt";
                        shoes = "Sandals";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (time)
                {
                    case "Morning":
                        ourfit = "T-Shirt";
                        shoes = "Sandals";
                        break;
                    case "Afternoon":
                        ourfit = "Swim Suit";
                        shoes = "Barefoot";
                        break;
                    case "Evening":
                        ourfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"It's {degrees} degrees, get your {ourfit} and {shoes}.");
        }
    }
}
