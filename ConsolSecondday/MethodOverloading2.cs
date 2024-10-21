using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class MethodOverloading2
    {
        double da, ta, gross, basic, hra;
        void calculatersalary(double basic,double hra,double da)
        {
            gross = basic + hra + da;
            Console.WriteLine("Gross salaryis{0}", gross);
        }
        void calculatersalary(double basic, double hra, double da,double ta)
        {
            gross = basic + hra + da+ta;

        }

        static void Main(string[] args)
        {
            MethodOverloading2 emp = new MethodOverloading2();
            emp.calculatersalary(100, 200, 2000);
            emp.calculatersalary(100, 200, 2000, 243);

            Console.ReadLine();

        }
    }
}
