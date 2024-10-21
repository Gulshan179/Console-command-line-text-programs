using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsolSecondday
{
    public class Employee2
    {
        public int id { get; set; } 
        public string name { get; set; }
        public string Designation { get; set; } 
        public double Salary { get; set; }
        public virtual double CalculateBonus(double Salary)
        {
            return 50000;
        }
    }
    public class Developer : Employee2
    {
        public override double CalculateBonus(double Salary)
        {
            double baseSalry=base.CalculateBonus(Salary);
            double calculatedSalaru = Salary * .20;
            if(baseSalry>=calculatedSalaru)
            {
                return baseSalry;
            }
            else
            {
                return calculatedSalaru;
            }
        }
    }

    public class Manager:Employee2
    {
        public override double CalculateBonus(double Salary)
        {
            double baseSalry = base.CalculateBonus(Salary);
            double calculatedSalaru = Salary * .25;
            if(baseSalry>=calculatedSalaru)
            {
                return baseSalry;
            }
            else
            {
                return calculatedSalaru;
            }
        }
    }


    public class Admin:Employee2
    {
        //return fixed bonus 

    }
    class methodOverridings
    {
        static void Main(string[] args)
        {
            Employee2 emp = new Employee2
            {
                id = 1001,
                name = "Gulshan",
                Salary = 50000,
                Designation="Developer"

            };
            double bonus=emp.CalculateBonus(emp.Salary);
            Console.WriteLine($"Name:{emp.name},Designation{emp.Designation},Salary{emp.Salary},");
            Console.WriteLine();
            Employee2 emp1 = new Employee2
            {
                id = 1002,
                name = "Roshan",
                Salary = 800000,
                Designation = "Manager"
            };
            bonus=emp1.CalculateBonus(emp1.Salary);
         
            
        }
    }

}
