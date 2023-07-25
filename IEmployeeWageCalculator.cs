namespace PracticeSheet
{
    interface IEmployeeWageCalculator
    {
        void AddCompany(string companyName, int workingDaysPerMonth, int totalWorkingHours, int hourlyPayRate);
        void ComputeEmployeeWage();
    }
}
