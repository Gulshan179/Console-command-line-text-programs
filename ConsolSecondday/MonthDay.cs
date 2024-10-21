using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class MonthDay
    {
        static void Main(string[] args)
        {
            int day;
            float fine = 0;
            Console.WriteLine("Enter Total Day");
            day=Convert.ToInt32(Console.ReadLine());
            if (day <= 5)
            {
                fine = 0;

            }
            else if (day > 5 && day >= 10)
            {
                fine = (day - 5) * 0.5f;
            }
            else if (day > 10 && day <= 30) 
            {
                fine = 5 * 0.5f + (day - 10) * 1;
            }
            else
            {
                fine = 5 * 0.5f + 20 * 1 + (day - 30) * 1.5f;
                Console.WriteLine("Cancel Your member");

            }
            Console.WriteLine("Your Fine" + fine);
            Console.ReadLine();

        }
    }
}
