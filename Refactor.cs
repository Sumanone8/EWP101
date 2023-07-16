using System;

namespace PracticeSheet
{
    class EmployeeWageCalculator
    {
        // Class variables
        private const int workingDaysPerMonth = 20;
        private const int totalWorkingHours = 100;
        private const int hourlyPayRate = 20;

        // Class method to compute employee wage
        public static void ComputeEmployeeWage()
        {
            Console.WriteLine("Welcome to the Employee Wage Calculator!");

            // Variables to store the total wage, total working hours, and the daily wage
            int totalWage = 0;
            int totalHoursWorked = 0;

            Random random = new Random();

            for (int day = 1; day <= workingDaysPerMonth && totalHoursWorked < totalWorkingHours; day++)
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
                totalHoursWorked += workHours;

                Console.WriteLine($"Day {day}: Work hours: {workHours}, Daily wage: ${dailyWage}");

                if (totalHoursWorked >= totalWorkingHours)
                    break;
            }

            Console.WriteLine("\nCalculation for the month completed.");
            Console.WriteLine($"Total working hours: {totalHoursWorked}");
            Console.WriteLine($"Total wage for the month: ${totalWage}");
        }
    }
}