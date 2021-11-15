using System;

namespace EmpWage_OOPs
{
	public class Program
	{
		public static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 5, 10);
            empWageBuilder.addCompanyEmpWage("Wipro", 25, 8, 20);
            empWageBuilder.addCompanyEmpWage("TCS", 24, 7, 25);
            empWageBuilder.ComputeEmpWage();
            Console.ReadLine();
        }
	}
}
