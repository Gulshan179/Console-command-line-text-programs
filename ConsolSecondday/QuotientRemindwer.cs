using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class QuotientRemindwer
    {
        static void Main(string[] args)
        {
            int dividend = 50, divisor = 8;
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Divided {0}divisor{1}", dividend, divisor);
            Console.WriteLine("Quatation{0}", quotient);
            Console.WriteLine("Reminder", remainder);
            Console.ReadLine();
        }
    }
}
