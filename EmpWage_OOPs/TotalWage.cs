using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Wage14
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);

        public void computeEmpWage();

        public int getTotalWage(string company);
    }
    class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = empRatePerHour;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.totalEmpWage = 0;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string toString()
        {
            return "Total Empaloyee Wage for Company : " + this.company + " is : " + this.totalEmpWage;
        }

        public class EmpWageBuilder : IComputeEmpWage
        {
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;

            private LinkedList<CompanyEmpWage> companyEmpWageList;
            private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

            public EmpWageBuilder()
            {
                this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
                this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
            }

            public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            {
                CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
                this.companyEmpWageList.AddLast(companyEmpWage);
                this.companyToEmpWageMap.Add(company, companyEmpWage);
            }

            public void computeEmpWage()
            {
                foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
                {
                    companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                    Console.WriteLine(companyEmpWage.toString());
                }
            }

            private int computeEmpWage(CompanyEmpWage companyEmpWage)...

            public int getTotalWage(string company)
            {
                return this.companyToEmpWageMap[company].totalEmpWage;
            }
        }

        class Program
        {
            static void Main(string[] args)
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
}
