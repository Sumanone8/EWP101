using System;

namespace PracticeSheet
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello Fellow Learners!\nWelcome to Employee Wage Problem.\nEnter the index no. of the program you want to run.");
            Console.WriteLine("1.Basic Code\n2.Refactored Code\n3.For Multiple Companies");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PracticeClass practiceClass = new PracticeClass();
                    practiceClass.DoPractice();
                    break;
                case 2:
                    EmployeeWageCalculator1 employeeWageCalculator1 = new EmployeeWageCalculator1();
                    EmployeeWageCalculator1.ComputeEmployeeWage1();
                    break;
                case 3:
                    EmpWageBuilder empWageBuilder = new EmpWageBuilder();
                    empWageBuilder.AddCompany("Company A", 20, 100, 20);
                    empWageBuilder.AddCompany("Company B", 22, 110, 25);
                    empWageBuilder.ComputeEmployeeWage();
                    break;
                default:
                    Console.WriteLine("Please Enter a Valid Index No.");
                    break;
            }
            Console.ReadLine();
        }
    }
}