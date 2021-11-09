using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_OOPs
{
    class UC5_Monthly_Emp_Wage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;

        public static void MonthlyEmpWage()
        {
            //VARIABLE
            int empHrs = 0, empwage = 0, totalempwage = 0;

            //Computation

            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empwage = empHrs * EMP_RATE_PER_HOUR;
                totalempwage += empwage;
                Console.WriteLine("Employee Wage of Day " + (day + 1) + " is : " + empwage);
            }
            Console.WriteLine("Total Employee Wage : " + totalempwage);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem. ");

            UC5_Monthly_Emp_Wage.MonthlyEmpWage();
        }
    }
}
