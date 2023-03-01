using System;

namespace _04._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double examGrade = 0;


            double lowGrade = 0;
            double middleGrade = 0;
            double goodGrade = 0;
            double highGrade = 0;

            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if(grade >= 2 && grade <= 2.99)
                {
                    lowGrade ++;
                    examGrade += grade;
                }
                else if(grade >= 3 && grade <= 3.99)
                {
                    middleGrade++;
                    examGrade+= grade;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    goodGrade++;
                    examGrade += grade;
                }
                else if (grade >= 5 && grade <= 6)
                {
                    highGrade++;
                    examGrade += grade;
                }
            }

            Console.WriteLine($"Top students: {((highGrade / students)* 100).ToString("0.00")}%");
            Console.WriteLine($"Between 4.00 and 4.99: {((goodGrade / students)* 100).ToString("0.00")}%");
            Console.WriteLine($"Between 3.00 and 3.99: {((middleGrade / students)* 100).ToString("0.00")}%");
            Console.WriteLine($"Fail: {((lowGrade / students)* 100).ToString("0.00")}%");
            Console.WriteLine($"Average: {(examGrade / students).ToString("0.00")}");
        }
    }
}
