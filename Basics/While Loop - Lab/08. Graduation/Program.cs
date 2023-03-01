using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int level = 0;
            double middleGrade = 0;
            int excluded = 0;

            while(level != 12)
            {
                level++;

                double grade = double.Parse(Console.ReadLine());

                middleGrade += grade;
                
                if(grade < 4)
                {
                    excluded++;
                    
                    if(excluded == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {level - 1} grade");
                        break;
                    }
                }

                if(level ==12)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {(middleGrade / 12).ToString("0.00")}");
                }
            }
        }
    }
}
