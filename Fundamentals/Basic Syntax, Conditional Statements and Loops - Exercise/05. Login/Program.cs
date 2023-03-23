using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();

            char[] chars = userName.ToCharArray();
            Array.Reverse(chars);
            string expectedPass = new string(chars);

            string input;
            int count = 0;

            while ((input = Console.ReadLine()) != expectedPass)
            {
                count++;
                if(count < 4)
                    Console.WriteLine("Incorrect password. Try again.");
                else
                {
                    Console.WriteLine($"User {userName} blocked!");
                    return;
                }
            }

            if(input == expectedPass)
            {
                Console.WriteLine($"User {userName} logged in.");
            }
        }
    }
}
