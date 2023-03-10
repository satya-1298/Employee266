using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace Employee
{

    public class EmployeeCheck
    {
        const int FullTime = 1, EmpRate = 20;
        const int PartTime = 2;
        public static void attendence()
        {

            int EHours = 0;
            int EWage = 0;
            //int EmpRate = 20;
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
            EWage = EHours * EmpRate;
            Console.WriteLine("Emp Wages is " + EWage);


        }
        public void wagesformonth()
        {
            int totalsalary = 0;
            int days = 20;
            //int PartTime = 2;
            int Ewage = EmpRate*8;
            // for (int i = 0; i <= 20 && (DailyHours >=100); i++) 
            for (int i = 0; i < 20; i++)
            {
                Random random = new Random();
                int Varible = random.Next(0, 3);
                switch (Varible)
                {
                    case 1:
                        totalsalary = Ewage * days;
                        break;
                    case 2:
                        totalsalary = (Ewage / 2) * days;
                        break;


                }
            }
            Console.WriteLine("Wages for month:" + totalsalary);
        }
        public void calculateWage()
        {
            int totalsalary = 0;
            int WHours = 8;
             int DHours = 0;
             for (int i = 0; i <= 20 && DHours < 100; i++)
            //for (int i = 0; i < 20; i++)
            {
                Random random = new Random();
                int Varible = random.Next(0, 3);
                switch (Varible)
                {
                    case 1:
                        totalsalary += EmpRate * WHours;
                        DHours += 8;
                        break;
                    case 2:
                        totalsalary += (EmpRate / 2) * WHours;
                        DHours += 4;
                        break;


                }

            }
            Console.WriteLine("calcuate salary for 100Hrs  :" + totalsalary); 
        }
    }


}
