using System;

namespace _01._Numbers_Ending_in_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            for (int i = 0; i < 1000; i++)
            {
                num++;

                if(num == 7 || num %10 == 7)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
