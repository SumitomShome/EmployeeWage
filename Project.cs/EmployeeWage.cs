using System;
namespace Wage
{
    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public static int ComputeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            Console.WriteLine("Welcome to Employee Wage Problem");
            //Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            //Computation
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
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
                Console.WriteLine("Day#: " + totalWorkingDays + "  Emp Hrs: " + empHrs);
            }

            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for Company: " +company+ " is " + totalEmpWage);
            Console.ReadKey();
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage("DMart", 20, 2, 10);
            ComputeEmpWage("Reliance", 10, 4, 20);
        }
    }
}

