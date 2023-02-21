using System;

namespace _07._House_Painting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //разход на боя
            double greenPaintCostPerLt = 3.4;
            double redPaintCostPerLt = 4.3;

            //височина на къщата
            double houseHeight = double.Parse(Console.ReadLine());
            //дължина на къщата
            double houseLength = double.Parse(Console.ReadLine());
            //височина на покрива
            double roofHeight = double.Parse(Console.ReadLine());

            //лице на вратата
            double doorArea = 1.2 * 2;

            //лице на прозорец
            double windowArea = 1.5 * 1.5;


            //лице на предната стена 
            double frontAndBack = houseHeight * houseHeight;
            double sideWays = houseHeight * houseLength;

            //покрив
            double roofFrontAndBack = ((houseHeight / 2) * roofHeight);
            double roofSideWays = houseHeight * houseLength;

            //квадратни метри на къщата
            double houseSqMeters = ((frontAndBack * 2) - doorArea) + (sideWays * 2) - (windowArea * 2);

            //квадратни метри на покрива
            double roofSqMeters = (roofFrontAndBack*2) + (roofSideWays * 2);

            //output
            Console.WriteLine("{0:F2}", houseSqMeters / greenPaintCostPerLt);
            Console.WriteLine("{0:F2}", roofSqMeters / redPaintCostPerLt);
        }
    }
}
