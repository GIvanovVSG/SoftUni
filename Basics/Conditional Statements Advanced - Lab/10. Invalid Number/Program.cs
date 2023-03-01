using System;

namespace _10._Invalid_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if(number == 0 || number >= 100 && number <= 200)
            {
                //Do nothing
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
