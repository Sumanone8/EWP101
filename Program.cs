using System;

namespace PracticeSheet
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello Suman! Welcome.");
            Console.WriteLine("Let's begin!");

            EmployeeWageCalculator employeeWageCalculator = new EmployeeWageCalculator();
            EmployeeWageCalculator.ComputeEmployeeWage();
            Console.ReadLine();
        }
    }
}
