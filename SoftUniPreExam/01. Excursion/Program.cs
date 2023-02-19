using System;

namespace _01._Excursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peoples = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            int transportTickets = int.Parse(Console.ReadLine());
            int museumTickets = int.Parse(Console.ReadLine());

            int sleepPrice = 20;
            double transport = 1.60;
            int ticket = 6;

            int nightsPrice = nights * sleepPrice;
            double transportPrice = transportTickets * transport;
            int museumPrice = museumTickets * ticket;

            double result = (nightsPrice + transportPrice + museumPrice) * peoples;
            Console.WriteLine($"{(result += result * 0.25):F2}");
        }
    }
}
