using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Pattern_Matching
{
     class SwitchExpression
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Enter Day");
            string day=Console.ReadLine();
            string Message = string.Empty;
            
            switch(day.ToUpper())
            {
                case "Sunday":
                    Message = "Weekend";
                    break;
                case "Monday":
                    Message = "start of the Weekday";
                    break;
                case "Friday":
                    Message = "End of the Weekday";
                    break;
                default:
                    Message = "Invalid Day";
                    break;

            }
            Console.WriteLine($"{day} is {Message}");
            Console.ReadLine();
        }
    }
}
