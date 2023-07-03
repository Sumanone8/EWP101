using System;

namespace PracticeSheet
{
    class PracticeClass
    {
        public void DoPractice()
        {
            Console.WriteLine("Welcome to Employment Wage Problem 101");

            //UC2 - Daily Wage of a Employee
            int hourlyRate = 20;
            int hoursWorked = 8;

            int dailyWage = hourlyRate * hoursWorked;

            Console.WriteLine("Daily Employee Wage: $" + dailyWage);
        }
    }
}