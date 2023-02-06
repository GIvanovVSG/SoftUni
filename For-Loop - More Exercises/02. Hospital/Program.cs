using System;

namespace _02._Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;

            for (int i = 1; i <= days; i++)
            {
                int patients = int.Parse(Console.ReadLine());

                if(i % 3 == 0 && treatedPatients < untreatedPatients)
                {
                    doctors++;
                }

                if(patients <= doctors)
                {
                    treatedPatients += patients;
                }
                else
                {
                    untreatedPatients += patients - doctors;
                    treatedPatients += doctors;
                }
            }

            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
