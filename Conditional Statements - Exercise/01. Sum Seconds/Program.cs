using System;

namespace _01._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totalTime = firstTime+ secondTime + thirdTime;

            Console.Write(totalTime / 60);
            Console.Write(":");
            Console.Write("{0:D2}", totalTime %60);
        }
    }
}
