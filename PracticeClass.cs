using System;
namespace PracticeSheet
{
    class PracticeClass
    {
        public void DoPractice()
        {
                Console.WriteLine("Welcome to the Employee Wage Calculator!");

                // Constants for the number of working days in a month and the hourly pay rate
                const int workingDaysPerMonth = 20;
                const int hourlyPayRate = 20;

                // Variables to store the total wage for the month and the daily wage
                int totalWage = 0;

                Random random = new Random();

                for (int day = 1; day <= workingDaysPerMonth; day++)
                {
                    int workHours;

                    // Generate a random number to determine the work type: 0 for full-time, 1 for part-time, 2 for absent
                    int workType = random.Next(0, 3);

                    switch (workType)
                    {
                        case 0: // Full-time
                            workHours = 8;
                            break;

                        case 1: // Part-time
                            workHours = 4;
                            break;

                        default: // Absent
                            workHours = 0;
                            break;
                    }

                    int dailyWage = workHours * hourlyPayRate;
                    totalWage += dailyWage;

                    Console.WriteLine($"Day {day}: Random number: {workType}, Work type: {GetWorkTypeName(workType)}, Work hours: {workHours}, Daily wage: ${dailyWage}");
                }

                Console.WriteLine("\nCalculation for the month completed.");
                Console.WriteLine($"Total wage for the month: ${totalWage}");
            }

            static string GetWorkTypeName(int workType)
            {
                switch (workType)
                {
                    case 0:
                        return "Full-time";
                    case 1:
                        return "Part-time";
                    default:
                        return "Absent";
                }
            }
        }

    }