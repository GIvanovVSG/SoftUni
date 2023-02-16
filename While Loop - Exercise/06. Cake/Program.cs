using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string stop;
            int pieces = width * height;
            int piecesToGet;

            while((stop = Console.ReadLine()) != "STOP")
            {
                piecesToGet = int.Parse(stop);
                pieces -= piecesToGet;
                
                if(pieces <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
                    break;
                }
            }

            if(stop == "STOP")
            {
                Console.WriteLine($"{pieces} pieces are left.");
            }
        }
    }
}
