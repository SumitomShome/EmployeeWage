using System;
using System.Collections.Generic;
public class EmpWageBuilder
{
    public const int IS_FULL_TIME = 1;
    public const int IS_PART_TIME = 2;
    private int numOfCompany = 0;
    private CompanyEmpWage[] companyEmpWageArray;
    public EmpWageBuilder()
    {
        this.companyEmpWageArray = new LinkedList<CompanyEmpWage>();
    }
    public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
    {
        companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
        numOfCompany++;
    }
    public void computeEmpWage()
    {
        for (int i = 0; i< numOfCompany; i++)
        {
            companyEmpWageArray.setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
            Console.WriteLine(this.companyEmpWageArray[i].toString());
        }
    }
    private int computeEmpWage(CompanyEmpWage companyEmpWage)
    {
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
        while(totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays <= companyEmpWage.numOfWorkingDays)
        {
            totalWorkingDays++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch(empCheck)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            totalEmpHrs += empHrs;
            Console.WriteLine("Day#: " + totalWorkingDays + " Emp Hrs: " + empHrs);
        }
        return totalEmpHrs * companyEmpWage.empRatePerHour;
    }
}