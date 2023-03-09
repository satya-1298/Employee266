using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class EmployeeCheck
    {
        public static void attendence()
        {
            int FullTime = 1;
            //int PartTime = 2;
            //int EHours = 0;
            //int EWage = 0;
            Random random = new Random();
            int Empcheck = random.Next(2);
            if (Empcheck == FullTime)
            {
                Console.WriteLine("the Employee is present");
                //EHours = 8;

            }
            else
            {
                Console.WriteLine("Employee is absent");
               // EHours = 0;
            }
        }
        
    }
}
