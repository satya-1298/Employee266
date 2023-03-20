using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Interface
    {
        const int FullTime = 1; //EmpRate = 20;
        const int PartTime = 2;
        private int  no_of_company=0;
        private CompanyEWages[] companyEWagesArray;

       
        public Interface()
        {
            this.companyEWagesArray = new CompanyEWages[5];
           
        }
        public void toCompanywage(string company, int EmpRate, int WDays, int Hpermonth)
        {
            companyEWagesArray[this.no_of_company] = new CompanyEWages(company, EmpRate, WDays, Hpermonth);
            no_of_company++;
        }
        public void computeWages()
        {
            for (int i=0;i<no_of_company;i++) 
            {
                companyEWagesArray[i].setTotalEWages(this.computeWages(this.companyEWagesArray[i]));
                Console.WriteLine(companyEWagesArray[i].toString());
            }
        }
        private int computeWages(CompanyEWages companyEWages)
        {
            int EHours = 0;
            int totalEHours = 0;
            int totalWDays = 0;

            while (totalEHours <= companyEWages.Hpermonth && totalWDays < companyEWages.WDays)
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
            return totalEHours*companyEWages.EmpRate;
        }   


    }
}

