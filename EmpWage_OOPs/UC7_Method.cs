using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_OOPs
{
    class UC7_Method
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;

        public static void Methods()
        {
            //Variable
            int empHrs = 0, totalempHrs = 0, totalWorkingDays = 0, empWage = 0;
            //Computation
            while (totalempHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < MAX_HRS_IN_MONTH)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        empWage = 80;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        empWage = 160;
                        break;
                    default:
                        empHrs = 0;
                        empWage = 0;
                        break;
                }
                totalempHrs += empHrs;
                Console.WriteLine("Day " + totalWorkingDays + " Employee Wage : " + empWage);
            }
            int totalEmpWage = totalempHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee wage : " + totalEmpWage);

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem. ");

            UC7_Method.Methods();
        }
    }
}
