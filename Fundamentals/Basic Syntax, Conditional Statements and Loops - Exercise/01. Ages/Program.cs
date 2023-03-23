using System;

namespace _01._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());
            string person = "";

            if (ages >= 0 && ages <= 2)
            {
                person = "baby";
            }
            else if (ages >= 3 && ages <= 13)
            {
                person = "child";
            }
            else if (ages >= 14 && ages <= 19)
            {
                person = "teenager";
            }
            else if (ages >= 20 && ages <= 65)
            {
                person = "adult";
            }
            else
            {
                person = "elder";
            }

            Console.WriteLine(person);
        }
    }
}
