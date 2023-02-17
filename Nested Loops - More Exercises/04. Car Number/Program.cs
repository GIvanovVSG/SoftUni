using System;

namespace _04._Car_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fistDigit = int.Parse(Console.ReadLine());
            int lastDigit = int.Parse(Console.ReadLine());

            for (int numOne = fistDigit; numOne <= lastDigit; numOne++)
            {
                for (int numTwo = fistDigit; numTwo <= lastDigit; numTwo++)
                {
                    for (int numThree = fistDigit; numThree <= lastDigit; numThree++)
                    {
                        for (int numFour = fistDigit; numFour <= lastDigit; numFour++)
                        {
                            if(numOne % 2 == 0 && numFour % 2 != 0 && numOne > numFour && (numTwo + numThree) % 2 == 0 
                                || numOne % 2 != 0 && numFour % 2 == 0 && numOne > numFour && (numTwo + numThree) % 2 == 0)
                            {
                                Console.Write(numOne + "" + numTwo + "" + numThree + "" + numFour + "" + " ");
                            }
                        }
                    }
                }
            }
        }
    }
}
