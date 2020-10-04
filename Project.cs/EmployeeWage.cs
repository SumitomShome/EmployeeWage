using System;
namespace Wage
{
    class Program
    {
            Console.WriteLine("Welcome to Employee Wage Problem");
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
            Console.WriteLine(reliance.toString());
            Console.ReadKey();
        }
    }
}
