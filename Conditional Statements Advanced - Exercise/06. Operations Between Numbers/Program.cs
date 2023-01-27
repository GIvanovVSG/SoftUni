using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string op = Console.ReadLine();

            double result = 0.0;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                        result = num1 * num2;
                    break;
                case "/":
                    if (num1 == 0 || num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        result = num1 / num2;
                        if (result % 2 == 0)
                        {
                            Console.Write($"{num1} {op} {num2} = {result.ToString("0.00")}");
                        }
                        else
                        {
                            Console.Write($"{num1} {op} {num2} = {result.ToString("0.00")}");
                        }
                    }
                    break;
                case "%":
                    result = num1 % num2;
                    break;
                default:
                    break;
            }

            
            if(op == "%")
            {
                if (num1 == 0 || num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    Console.WriteLine($"{num1} {op} {num2} = {result}");
                }
            }
            else if (op == "+" || op == "-" || op == "*")
            {
                if (result % 2 == 0)
                {
                    Console.Write($"{num1} {op} {num2} = {result} - even");
                }
                else
                {
                    Console.Write($"{num1} {op} {num2} = {result} - odd");
                }
            }
        }
    }
}
