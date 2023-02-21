using System;

namespace _07._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int objects = int.Parse(Console.ReadLine());

            int workingHours = objects * 3;

            Console.WriteLine($"The architect {architectName} will need {workingHours} hours to complete {objects} project/s.");
        }
    }
}
