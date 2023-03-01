using System;

namespace _07._Safe_Passwords_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int passwords = int.Parse(Console.ReadLine());
            int charA = 35;
            int charB = 64;

            for (int i = 1; i <= passwords; i++)
            {
                for (int num1 = 1; num1 <= a; num1++)
                {
                    for (int num2 = 1; num2 <= b; num2++)
                    {
                        Console.Write(Convert.ToChar(charA));
                        Console.Write(Convert.ToChar(charB));
                        Console.Write(num1);
                        Console.Write(num2);
                        Console.Write(Convert.ToChar(charB));
                        Console.Write(Convert.ToChar(charA));
                        Console.Write("|");
                        charA++;
                        charB++;

                        if (charA == 56)
                        {
                            charA = 35;
                        }
                        else if(charB== 97)
                        {
                            charB = 64;
                        }

                        if(num1 == a && num2 == b || num2 == passwords)
                        {
                            return;
                        }
                    }
                }
            }
        }
    }
}
