using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_OOPs
{
    class UC1_Emp_Attendance
    {
        public static void empCheck()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int result = random.Next(0, 2);

            if (result == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem. ");

            UC1_Emp_Attendance.empCheck();
        }
    }
}
