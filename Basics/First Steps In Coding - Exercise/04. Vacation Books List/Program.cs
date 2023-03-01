using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesForOneHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int hoursPerDay = (pages / pagesForOneHour) / days;
            Console.WriteLine(hoursPerDay);
        }
    }
}
