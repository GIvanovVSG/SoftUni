using System;

namespace _08._Circle_Area_and_Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * (r * r);
            double circlePerimeter = Math.PI * 2 * r;

            Console.WriteLine("{0:F2}", circleArea);
            Console.WriteLine("{0:F2}", circlePerimeter);
        }
    }
}
