using System;

namespace _09.PadawanEquipme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double studentsCount = int.Parse(Console.ReadLine());
            double sabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());
            double freeBelts = studentsCount / 6;

            double cost = (sabersPrice * (studentsCount * 1.10)) + (robesPrice * studentsCount) + (beltsPrice * (studentsCount - freeBelts));
            

            if (money >= cost)
                Console.WriteLine($"The money is enough - it would cost {Math.Ceiling(cost):F2}lv.");
            else
                Console.WriteLine($"John will need {cost - money:F2}lv more.");
        }
    }
}
