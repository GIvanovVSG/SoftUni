using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lowGrades = int.Parse(Console.ReadLine());
            string enough;
            double numberLowGrades = 0;
            double allCases = 0;
            string caseName = "";
            double middleGrade = 0;

            while ((enough = Console.ReadLine()) != "Enough")
            {
                caseName = enough;
                double grade = double.Parse(Console.ReadLine());
                allCases++;
                middleGrade += grade;

                if(grade <= 4)
                {
                    numberLowGrades++;

                    if(numberLowGrades == lowGrades)
                    {
                        Console.WriteLine($"You need a break, {numberLowGrades} poor grades.");
                        break;
                    }
                }

            }

            if(enough == "Enough")
            {
                Console.WriteLine($"Average score: {(middleGrade / allCases).ToString("0.00")}");
                Console.WriteLine($"Number of problems: {allCases}");
                Console.WriteLine($"Last problem: {caseName}");
            }
        }
    }
}
