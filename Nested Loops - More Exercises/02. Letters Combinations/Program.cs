using System;

namespace _02._Letters_Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());
            bool firstBool = false;
            bool secondBool = false;
            bool thirdBool = false;

            int count = 0;

            for (char charOne = 'a'; charOne <= 'z'; charOne++)
            {
                if (charOne >= firstChar && charOne <= secondChar && charOne != thirdChar)
                {
                    firstBool = true;

                    for (char charTwo = 'a'; charTwo <= 'z'; charTwo++)
                    {
                        if (charTwo >= firstChar && charTwo <= secondChar && charTwo != thirdChar)
                        {
                            secondBool = true;

                            for (char charThree = 'a'; charThree <= 'z'; charThree++)
                            {
                                if (charThree >= firstChar && charThree <= secondChar && charThree != thirdChar)
                                {
                                    thirdBool = true;

                                    if (firstBool == true && secondBool == true && thirdBool == true)
                                    {
                                        count++;
                                        Console.Write(charOne.ToString() + charTwo.ToString() + charThree.ToString() + " ");
                                    }
                                }
                            }
                        }
                    }
                }

                firstBool = false;
                secondBool = false;
                thirdBool = false;
            }

            Console.Write(count);
        }
    }
}