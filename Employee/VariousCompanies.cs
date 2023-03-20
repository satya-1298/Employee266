using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class VariousCompanies
    {
        const int FullTime = 1; //EmpRate = 20;
        const int PartTime = 2;
        private string company;
        private int EmpRate;
        private int WDays;
        private int Hpermonth;
        private int totalEmpRate;
        private int totalEwages;
        public VariousCompanies(string company, int EmpRate, int WDays, int Hpermonth)
        {
            this.company = company;
            this.EmpRate = EmpRate;
            this.WDays = WDays;
            this.Hpermonth = Hpermonth;
        }
        public void wage()
        {
            int totalEHours = 0;
            int totalWDays = 0;
            int EHours = 0;
            int EWage = 0;
            //int EmpRate = 20;
            while (totalEHours <= this.Hpermonth && totalWDays < this.WDays)
            {
                totalWDays++;
                Random random = new Random();
                int Empcheck = random.Next(0, 3);
                if (Empcheck == FullTime)
                {
                    Console.WriteLine("the Employee is present");
                    EHours = 8;

                }
                else if (Empcheck == PartTime)
                {
                    Console.WriteLine("Emp is part time present ");
                    EHours = 4;
                }
                else
                {
                    Console.WriteLine("Employee is absent");
                    EHours = 0;
                }

                totalEHours += EHours;
                Console.WriteLine("Day#:" + totalWDays + "EmployeeHours:" + EHours);

            }
             totalEwages = totalEHours *this. EmpRate;
            Console.WriteLine("Total EmpWages for Company:" + company + "is :" + totalEwages);
        }

            public string Company()
            {
                return "Total EmpWages for Company:" + this.company + "is :" + this.totalEwages;
            }
        
      
    }
}
