using System;

namespace PracticeSheet
{
    class PracticeClass
    {
        public void DoPractice()
        {
            Console.WriteLine("Welcome to the Employee Wage Calculator!");

            // Generate a random number to determine whether the employee is present or absent
            Random random = new Random();
            bool isPresent = random.Next(0, 2) == 0;

            if (isPresent)
            {
                int fullTimeWorkHours = 8;
                int hourlyPayRate = 20;
                int dailyWage = fullTimeWorkHours * hourlyPayRate;
                Console.WriteLine("Employee is present.");
                Console.WriteLine("Daily wage: $" + dailyWage);
            }
            else
            {
                Console.WriteLine("Employee is absent.");
                Console.WriteLine("No daily wage earned.");
            }
        }
    }
}