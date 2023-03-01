using System;

namespace _05._Game_Of_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());

            double n1 = 0;
            double n2 = 0;
            double n3 = 0;
            double n4 = 0;
            double n5 = 0;
            
            double countN1 = 0;
            double countN2 = 0;
            double countN3 = 0;
            double countN4 = 0;
            double countN5 = 0;
            double invalidNum = 0;
            double result = n1 + n2 + n3 + n4 + n5;

            for (int i = 0; i < moves; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if(number >= 0 && number <= 9)
                {
                    countN1++;
                    result += number * 0.20;
                }
                else if (number >= 10 && number <= 19)
                {
                    countN2++;
                    result += number * 0.30;
                }
                else if (number >= 20 && number <= 29)
                {
                    countN3++;
                    result += number * 0.40;
                }
                else if (number >= 30 && number <= 39)
                {
                    countN4++;
                    result += 50;
                }
                else if (number >= 40 && number <= 50)
                {
                    countN5++;
                    result += 100;
                }
                else
                {
                    invalidNum++;
                    result /= 2;
                }
            }

            Console.WriteLine($"{(result).ToString("0.00")}");
            Console.WriteLine($"From 0 to 9: {((countN1 / moves) * 100).ToString("0.00")}%");
            Console.WriteLine($"From 10 to 19: {((countN2 / moves) * 100).ToString("0.00")}%");
            Console.WriteLine($"From 20 to 29: {((countN3 / moves) * 100).ToString("0.00")}%");
            Console.WriteLine($"From 30 to 39: {((countN4 / moves) * 100).ToString("0.00")}%");
            Console.WriteLine($"From 40 to 50: {((countN5 / moves) * 100).ToString("0.00")}%");
            Console.WriteLine($"Invalid numbers: {((invalidNum / moves) * 100).ToString("0.00")}%");
        }
    }
}
