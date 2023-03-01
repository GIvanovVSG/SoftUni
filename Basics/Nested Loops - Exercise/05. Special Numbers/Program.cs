using System;
using System.Threading;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1111; i < 9999; i++)
            {
                string currentNum = i.ToString();
                
                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());

                    if(n % currentDigit == 0)
                    {
                        count++;

                        if(count == 4)
                        Console.Write(currentNum + " ");
                    }
                }
                count = 0;
            }
        }
    }
}
