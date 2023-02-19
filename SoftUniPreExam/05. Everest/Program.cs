using System;

namespace _05._Everest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string end = Console.ReadLine();
            int height = 5364;
            int days = 1;

            while (end != "END")
            {
                if(end == "Yes")
                days++;

                int meters = int.Parse(Console.ReadLine());

                if(days > 5)
                {
                    Console.WriteLine("Failed!");
                    Console.WriteLine($"{height}");
                    break;
                }


                height += meters;

                if (height >= 8848)
                {
                    Console.WriteLine($"Goal reached for {days} days!");
                    break;
                }

                end = Console.ReadLine();
            }
            
            if(end == "END")
            {
                
                Console.WriteLine("Failed!");
                Console.WriteLine($"{height}");
            }
        }
    }
}
