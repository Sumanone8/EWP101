using System;

namespace PracticeSheet
{
    class EmpWageBuilder
    {
        // Company-specific variables
        private string companyName;
        private int workingDaysPerMonth;
        private int totalWorkingHours;
        private int hourlyPayRate;
        private int totalWage = 0;
        private int totalHoursWorked = 0;

        // Constructor to initialize company-specific variables
        public EmpWageBuilder(string name, int workingDays, int workingHours, int payRate)
        {
            companyName = name;
            workingDaysPerMonth = workingDays;
            totalWorkingHours = workingHours;
            hourlyPayRate = payRate;
        }

        // Class method to compute employee wage for the company
        public void ComputeEmployeeWage()
        {
            Console.WriteLine($"Welcome to {companyName} Employee Wage Calculator!");

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
