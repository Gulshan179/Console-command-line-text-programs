using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class Enum
    {
        enum Days
        {
            //Sun,Mon,Tue,Wed,Thu,Fri,Sat

            //Sun=4,Mon,Tue,Wed,Thu,Fri,Sat
            Sun,Mon,Tue,Wed=5,Thu,Fri,Sat

        };
        static void Main(string[] args)
        {
            int WeekdayStart = (int)Days.Mon;
            int Weekdaybegin = (int)Days.Sun;
            int WeekdayEnd = (int)Days.Fri;
            int WeekdayMiddle = (int)Days.Wed;
            int Weekdauend = (int)Days.Sat;

            Console.WriteLine("Sunday:{0}",Weekdaybegin);
            Console.WriteLine("monday:{0}", WeekdayStart);
            Console.WriteLine("monday is:{0}", Days.Mon);
            Console.WriteLine("Friday:{0}", WeekdayEnd);
            Console.WriteLine("Wednesday:{0}", WeekdayMiddle);
            Console.WriteLine("Saturday:{0}", Weekdauend);
            Console.ReadLine();


        }
    }
}
