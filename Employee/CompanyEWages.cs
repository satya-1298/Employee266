using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class CompanyEWages

    {
        public string company;
        public int EmpRate;
        public int WDays;
        public int Hpermonth;
       // private int totalEmpRate;
        public int totalEwages;
        public  CompanyEWages(string company, int EmpRate, int WDays, int Hpermonth)
        {
            this.company = company;
            this.EmpRate = EmpRate;
            this.WDays = WDays;
            this.Hpermonth = Hpermonth;
        }
        public void setTotalEWages(int totalEWages)
        {
            this.totalEwages = totalEWages;
        }
        public string toString()
        {
            return "Total EmpWages for Company:" + this.company + "is :" + this.totalEwages;

        }

    }
}
