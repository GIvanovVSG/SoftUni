using System;

namespace _01._Unique_PIN_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thidrdNum = int.Parse(Console.ReadLine());
            bool firstBool = false;
            bool secondBool = false;
            bool thirdBool = false;

            for (int num1 = 1; num1 <= firstNum; num1++)
            {
                if (num1 % 2 == 0)
                {
                    firstBool = true;
                     
                    for (int num2 = 1; num2 <= secondNum; num2++)
                    {
                        if (num2 == 2 || num2 == 3 || num2 == 5 || num2 == 7)
                        {
                            secondBool = true;

                            for (int num3 = 1; num3 <= thidrdNum; num3++)
                            {
                                if (num3 % 2 == 0)
                                {
                                    thirdBool = true;
                                    if (firstBool == true && secondBool == true && thirdBool == true)
                                    {
                                        Console.WriteLine(num1 + " " + num2 + " " + num3);
                                    }
                                }
                            }
                        }
                    }
                }
                firstBool= false;
                secondBool= false;
                thirdBool= false;

            }
        }
    }
}
