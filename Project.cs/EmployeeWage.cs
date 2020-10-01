using System;
namespace Wage
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Welcome to the Employee Wage Problem");
            //Constants
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //Computation
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
           empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage = " + empWage);
            Console.ReadKey();
         }
    }
}
