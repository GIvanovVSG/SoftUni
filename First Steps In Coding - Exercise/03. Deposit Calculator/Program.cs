using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double interestRate = double.Parse(Console.ReadLine()) / 100;

            double sum = deposit + term * ((deposit * interestRate) / 12);
            Console.WriteLine(sum);
        }
    }
}
