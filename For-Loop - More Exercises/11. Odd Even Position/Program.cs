using System;

namespace _11._Odd_Even_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddNum = 0;
            double evenNum = 0;
            double oddSum = 0;
            double evenSum = 0;
            double oddMin = 1000000000.0;
            double oddMax = -1000000000.0;
            double evenMin = 1000000000.0;
            double evenMax = -1000000000.0;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 1)
                {
                    oddNum = num;
                    oddSum += oddNum;
                    if (oddNum > oddMax)
                    {
                        oddMax = oddNum;
                    }

                    if (oddNum < oddMin)
                    {
                        oddMin = oddNum;
                    }
                }
                else
                {
                    evenNum = num;
                    evenSum += evenNum;
                    if (evenNum > evenMax)
                    {
                        evenMax = evenNum;
                    }

                    if (evenNum < evenMin)
                    {
                        evenMin = evenNum;
                    }
                }
            }

            if (n == 0)
            {
                Console.WriteLine("OddSum=" + oddSum.ToString("0.00") + ",");
                Console.WriteLine("OddMin=No" + ",");
                Console.WriteLine("OddMax=No" + ",");
                Console.WriteLine("EvenSum=" + evenSum.ToString("0.00") + ",");
                Console.WriteLine("EvenMin=No" + ",");
                Console.WriteLine("EvenMax=No");
            }
            else if (n == 1)
            {
                Console.WriteLine("OddSum=" + oddSum.ToString("0.00") + ",");
                Console.WriteLine("OddMin=" + oddMin.ToString("0.00") + ",");
                Console.WriteLine("OddMax=" + oddMax.ToString("0.00") + ",");
                Console.WriteLine("EvenSum=" + evenSum.ToString("0.00") + ",");
                Console.WriteLine("EvenMin=No" + ",");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("OddSum=" + oddSum.ToString("0.00") + ",");
                Console.WriteLine("OddMin=" + oddMin.ToString("0.00") + ",");
                Console.WriteLine("OddMax=" + oddMax.ToString("0.00") + ",");
                Console.WriteLine("EvenSum=" + evenSum.ToString("0.00") + ",");
                Console.WriteLine("EvenMin=" + evenMin.ToString("0.00") + ",");
                Console.WriteLine("EvenMax=" + evenMax.ToString("0.00"));
            }
        }
    }
}
