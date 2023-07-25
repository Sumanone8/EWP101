using System;

namespace PracticeSheet
{
    class EmpWageBuilder : IEmployeeWageCalculator
    {
        private CompanyEmpWage[] companies;
        private int numOfCompanies;

        public EmpWageBuilder()
        {
            companies = new CompanyEmpWage[5]; // Assuming there are 5 companies; you can change this based on your needs
            numOfCompanies = 0;
        }

        public void AddCompany(string companyName, int workingDaysPerMonth, int totalWorkingHours, int hourlyPayRate)
        {
            if (numOfCompanies < companies.Length)
            {
                companies[numOfCompanies] = new CompanyEmpWage(companyName, workingDaysPerMonth, totalWorkingHours, hourlyPayRate);
                numOfCompanies++;
            }
            else
            {
                Console.WriteLine("Cannot add more companies. Maximum limit reached.");
            }
        }

        public void ComputeEmployeeWage()
        {
            foreach (CompanyEmpWage company in companies)
            {
                if (company != null)
                {
                    company.ComputeEmployeeWage();
                }
            }
        }
    }
}


