using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.IheritanceIO
{
     class Company
    {
        public void companyinfo()
        {
            Console.WriteLine("Company name,Compnay Department");
        }

    }
    class Employee4:Company
    {
        public void EmployeeInfo()
        {
            Console.WriteLine("Emp name,Emp id,emp age,Emp date of birth,comany name,Company Dept");
            //Console.WriteLine("Hi",companyinfo());
        }
        static void Main(string[] args)
        {
            Employee4 emp = new Employee4();
            emp.companyinfo();
            emp.EmployeeInfo();
            Console.ReadLine();
        }
    }
}
