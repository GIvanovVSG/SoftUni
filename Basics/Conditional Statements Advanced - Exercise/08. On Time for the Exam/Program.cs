using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int onTimeOrEarlier = ((hourExam * 60) + minutesExam) - ((arrivalHour * 60) + arrivalMinutes);
            int Later = ((arrivalHour * 60) + arrivalMinutes) - ((hourExam * 60) + minutesExam);
            int hoursOnTimeOrEarlier = hourExam - arrivalHour;
            int minutesOnTimeOrEarlier = minutesExam - arrivalMinutes;
            int hoursLater = arrivalHour - hourExam;
            int minutesLater = arrivalMinutes - minutesExam;

            if (onTimeOrEarlier >= 0 && onTimeOrEarlier <= 30)
            {
                Console.WriteLine("On time");
                if (onTimeOrEarlier != 0)
                {
                    if (hourExam > arrivalHour)
                    {
                        Console.WriteLine($"{minutesOnTimeOrEarlier + 60} minutes before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{minutesOnTimeOrEarlier} minutes before the start");
                    }
                }

            }
            else if (onTimeOrEarlier > 30)
            {
                Console.WriteLine("Early");
                if (onTimeOrEarlier < 60)
                {
                    if (minutesExam < arrivalMinutes)
                    {
                        Console.WriteLine($"{minutesOnTimeOrEarlier + 60} minutes before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{minutesOnTimeOrEarlier} minutes before the start");
                    }
                }
                else if(hoursOnTimeOrEarlier > 0 && minutesExam < arrivalMinutes)
                {
                    hoursOnTimeOrEarlier--;
                    minutesOnTimeOrEarlier += 60;
                    Console.WriteLine($"{hoursOnTimeOrEarlier}:{minutesOnTimeOrEarlier:D2} hours before the start");
                }
                else
                {
                    onTimeOrEarlier /= 60;
                    Console.WriteLine($"{onTimeOrEarlier}:{minutesOnTimeOrEarlier:D2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("Late");
                if (Later < 60)
                {
                    if (arrivalMinutes < minutesExam)
                    {
                        Console.WriteLine($"{minutesLater + 60} minutes after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{minutesLater} minutes after the start");
                    }
                }
                else
                {
                    hoursLater += hoursLater / 60;
                    minutesLater %= 60;
                    Console.WriteLine($"{hoursLater}:{minutesLater:D2} hours after the start");
                }
            }
        }
    }
}
