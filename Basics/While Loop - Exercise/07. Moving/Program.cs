using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int widthFreeSpace = int.Parse(Console.ReadLine());
            int lengthFreeSpace = int.Parse(Console.ReadLine());
            int heightFreeSpace = int.Parse(Console.ReadLine());
            string done;
            int carton;
            int freeSpace = (widthFreeSpace * lengthFreeSpace) * heightFreeSpace;


            while ((done = Console.ReadLine()) != "Done")
            {
                carton = int.Parse(done);

                freeSpace -= carton;

                if(freeSpace < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
                    break;
                }
            }

            if(done == "Done")
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
        }
    }
}
