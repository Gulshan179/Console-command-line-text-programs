using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class FindLeapYear
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter leap Year");
            year=Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine("{0} is leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is not Leap year", year);
            }
            Console.ReadLine();
        }
    }
}
