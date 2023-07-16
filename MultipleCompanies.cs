using System;

namespace PracticeSheet
{
    class EmployeeWageCalculator2
    {
        // Class method to compute employee wage for a company
        public static void ComputeEmployeeWage2(string companyName, int workingDaysPerMonth, int totalWorkingHours, int hourlyPayRate)
        {
            Console.WriteLine($"Welcome to {companyName} Employee Wage Calculator!");

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

            Console.WriteLine($"\nCalculation for {companyName} completed.");
            Console.WriteLine($"Total working hours: {totalHoursWorked}");
            Console.WriteLine($"Total wage for {companyName} for the month: ${totalWage}");
        }
    }
}
