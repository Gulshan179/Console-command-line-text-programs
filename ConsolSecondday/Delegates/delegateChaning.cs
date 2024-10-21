using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Delegates
{
    delegate int CalDelegate();
    class employee
    {
        int empid;
        int attend;
        int perday;
        int totalsalary;
        public employee()
        {
            this.empid = 1;
            this.attend = 30;
            this.perday = 200;
        }
        public int Parsalary()
        {
            return perday;

        }
        public int atted()
        {
            totalsalary = attend * perday;
            return totalsalary;
        }
        // public static int allownce()
        public int allownce()
        {
            double allow;
            int netsal = 0;
            allow = totalsalary * .20;
            netsal = totalsalary + (int)allow;
            return netsal;
        }

        static void Main(string[] args)
        {
            employee p1 = new employee();
            employee p2 = p1;
            employee p3 = p2;
            CalDelegate[] delegates = new CalDelegate[]
            {
             new CalDelegate(p1.Parsalary),
             new CalDelegate(p2.atted),
             new CalDelegate(p3.allownce)
            };
            CalDelegate chain = (CalDelegate)Delegate.Combine(delegates);
            int result = chain();
            Console.WriteLine(" net sal is {0}", result);
            Console.ReadLine();
        }
    }
}

