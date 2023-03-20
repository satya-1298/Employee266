using System;
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

            //EmployeeCheck emp = new EmployeeCheck();
            //emp.attendence();
            //emp.wagesformonth();
            //emp.calculateWage();
            //Empwage.wages();
            //VariousCompanies TATA = new VariousCompanies("TATA", 20, 2, 10);
            //VariousCompanies Reliance = new VariousCompanies("Reliance", 10, 4, 10);
            //TATA.wage();
            //Console.WriteLine(TATA.Company());
            //Reliance.wage();
            //Console.WriteLine(Reliance.Company());
            Interface emp = new Interface();
            emp.toCompanywage("TATA", 20, 2, 10);
            emp.toCompanywage("Reliance", 10, 4, 10);
            emp.computeWages();



        }
    }
}
