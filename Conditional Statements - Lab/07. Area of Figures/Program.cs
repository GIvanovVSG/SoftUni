using System;

namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if(figure == "square")
            {
                double sideLength = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", sideLength * sideLength);
            }
            else if(figure == "rectangle")
            {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", width * length);
            }
            else if(figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", Math.PI * (r * r));
            }
            else if(figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", (a * b) / 2);
            }
        }
    }
}
