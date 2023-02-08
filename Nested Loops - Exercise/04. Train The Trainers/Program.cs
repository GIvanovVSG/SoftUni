using System;
using System.Drawing;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string name;
            double allPresentationGrade = 0;
            int presentationCount = 0;

            while ((name = Console.ReadLine()) != "Finish")
            {
                int count = 0;
                double presentationGrade = 0;

                for (int i = 0; i < n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    count++;
                    presentationGrade += grade;
                    presentationCount++;
                }

                Console.WriteLine($"{name} - {(presentationGrade / count).ToString("0.00")}.");

                allPresentationGrade += presentationGrade;
            }

            Console.WriteLine($"Student's final assessment is {(allPresentationGrade / presentationCount).ToString("0.00")}.");
        }
    }
}
