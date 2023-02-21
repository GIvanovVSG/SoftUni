using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chickenMenu = 10.35;
            double fishMenu = 12.40;
            double vegeMenu = 8.15;

            double chickenMenuQuantity = double.Parse(Console.ReadLine()) * chickenMenu;
            double fishMenuQuantity = double.Parse(Console.ReadLine()) * fishMenu;
            double vegeMenuQuantity = double.Parse(Console.ReadLine()) * vegeMenu;

            double dessert = (chickenMenuQuantity + fishMenuQuantity + vegeMenuQuantity) * 0.20;
            Console.WriteLine(chickenMenuQuantity + fishMenuQuantity + vegeMenuQuantity + dessert + 2.50);
        }
    }
}
