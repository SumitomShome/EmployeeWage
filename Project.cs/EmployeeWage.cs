using System;
namespace Wage
{
    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem");
            //Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            //Computation
            while(totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
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
                Console.WriteLine("Day#: " + totalWorkingDays +  "  Emp Hrs: " + empHrs);
           }    
            
            int totalEmpWage = totalEmpHrs*EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage: " + totalEmpWage);
            Console.ReadKey();
         }
    }
}

