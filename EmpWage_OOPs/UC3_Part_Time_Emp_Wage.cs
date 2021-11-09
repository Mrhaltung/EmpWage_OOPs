using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_OOPs
{
    class UC3_Part_Time_Emp_Wage
    {
        public static void PartTimeEmpWage()
        {
            //Constatnts
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_WAGE_PER_HOUR = 20;

            //Variable
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            //Computation
            int empCheck = random.Next(0, 3);

            if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * EMP_WAGE_PER_HOUR;
            Console.WriteLine("Employee wage is : " + empWage);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem. ");

            UC3_Part_Time_Emp_Wage.PartTimeEmpWage();
        }
    }
}
