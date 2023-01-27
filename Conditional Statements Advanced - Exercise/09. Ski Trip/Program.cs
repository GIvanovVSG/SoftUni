using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()) - 1;
            string room = Console.ReadLine();
            string opinion = Console.ReadLine();

            double onePersonRoom = 18.00;
            double apartment = 25.00;
            double presidentApartment = 35.00;

            double price = 0;

            if(days < 10)
            {
                switch (room)
                {
                    case "apartment":
                        apartment -= apartment * 0.30;
                        price = apartment;
                        break;
                    case "president apartment":
                        presidentApartment -= presidentApartment * 0.10;
                        price = presidentApartment;
                        break;
                    case "room for one person":
                        price = onePersonRoom;
                        break;
                    default:
                        break;
                }
            }
            else if(days > 10 && days < 15)
            {
                switch (room)
                {
                    case "apartment":
                        apartment -= apartment * 0.35;
                        price = apartment;
                        break;
                    case "president apartment":
                        presidentApartment -= presidentApartment * 0.15;
                        price = presidentApartment;
                        break;
                    case "room for one person":
                        price = onePersonRoom;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (room)
                {
                    case "apartment":
                        apartment -= apartment * 0.50;
                        price = apartment;
                        break;
                    case "president apartment":
                        presidentApartment -= presidentApartment * 0.20;
                        price = presidentApartment;
                        break;
                    case "room for one person":
                        price = onePersonRoom;
                        break;
                    default:
                        break;
                }
            }

            switch (opinion)
            {
                case "positive":
                    Console.WriteLine($"{((price * days) + ((price * days) * 0.25)).ToString("0.00")}");
                    break;
                case "negative":
                    Console.WriteLine($"{((price * days) - ((price * days) * 0.10)).ToString("0.00")}");
                    break;
                default:
                    break;
            }
        }
    }
}
