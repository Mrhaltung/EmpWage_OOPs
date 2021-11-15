using System;

namespace EmpWage_OOPs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Wipro", 25, 5, 20);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total Wage for DMart company : " + empWageBuilder.getTotalWage("DMart"));
            Console.ReadLine();
        }
    }
}
