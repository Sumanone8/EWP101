using System;

namespace PracticeSheet
{
    class PracticeClass
    {
        public void DoPractice()
        {
            Console.WriteLine("Welcome to the Employee Wage Calculator!");

            // Generate a random number to determine the work type: 0 for full-time, 1 for part-time, 2 for absent
            Random random = new Random();
            int workType = random.Next(0, 3);

            int workHours;
            int hourlyPayRate;
            int dailyWage;

            switch (workType)
            {
                case 0: // Full-time
                    workHours = 8;
                    hourlyPayRate = 20;
                    dailyWage = workHours * hourlyPayRate;
                    Console.WriteLine("Employee is present and working full-time.");
                    Console.WriteLine("Daily wage: $" + dailyWage);
                    break;
                case 1: // Part-time
                    workHours = 4;
                    hourlyPayRate = 20;
                    dailyWage = workHours * hourlyPayRate;
                    Console.WriteLine("Employee is present and working part-time.");
                    Console.WriteLine("Daily wage: $" + dailyWage);
                    break;

                case 2: // Absent
                    Console.WriteLine("Employee is absent.");
                    Console.WriteLine("No daily wage earned.");
                    break;

                default:
                    Console.WriteLine("Invalid work type.");
                    break;

            }
        }
    }
}