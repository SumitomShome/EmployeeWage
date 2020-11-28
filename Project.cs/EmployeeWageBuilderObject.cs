using System;
using System.Collections.Generic;
public class EmpWageBuilder : IComputeEmpWage
{
    public const int IS_FULL_TIME = 1;
    public const int IS_PART_TIME = 2;
    private LinkedList<CompanyEmpWage> companyEmpWageList;
    private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;
    public EmpWageBuilder()
    {
        this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
        this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
    }
    public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
    {
        CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
        this.companyEmpWageList.AddLast(companyEmpWage);
        this.companyToEmpWageMap.Add(company, companyEmpWage);
    }
    public void computeEmpWage()
    {
        foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
        {
            companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
            Console.WriteLine(companyEmpWage.toString());
        }
    }
    public int getTotalWage(string company)
    {
        return this.companyToEmpWageMap[company].totalEmpWage;
    }
}