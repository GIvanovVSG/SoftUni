using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            double studentCount = 0;
            double standartCount = 0;
            double kidCount = 0;


            while (movie != "Finish")
            {
                double seats = double.Parse(Console.ReadLine());
                double movieTickets = 0;

                for (int i = 0; i < seats; i++)
                {
                    string seatType = Console.ReadLine();

                    if (seatType == "End")
                        break;
                    else if (seatType == "student")
                        studentCount++;
                    else if (seatType == "standard")
                        standartCount++;
                    else if (seatType == "kid")
                        kidCount++;
                    movieTickets++;
                }
                Console.WriteLine($"{movie} - {((movieTickets / seats) * 100).ToString("0.00")}% full. ");
                movie = Console.ReadLine();

            }

            double totalTickets = kidCount + standartCount + studentCount;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{((studentCount / totalTickets) * 100).ToString("0.00")}% student tickets.");
            Console.WriteLine($"{((standartCount / totalTickets) * 100).ToString("0.00")}% standard tickets.");
            Console.WriteLine($"{((kidCount / totalTickets) * 100).ToString("0.00")}% kids tickets.");
        }
    }
}
