﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages");

            EmployeeCheck.attendence();
            EmployeeCheck emp = new EmployeeCheck();
            emp.wagesformonth();
            emp.calculateWage();
            //EmployeeCheck.attendence(EmpRate);
            //EmployeeCheck.wagesformonth(int);

        }
    }
}
