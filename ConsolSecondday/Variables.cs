using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class Variables
    {
        static void Main()
        {
            byte centuries = 20;
            ushort year = 2000;
            uint days = 23232;
            ulong hours = 17343433;
            Console.WriteLine(centuries + "Centuries are" + year + "years or" + days + "days, or" + hours + "hours.");
            Console.ReadLine();
        }
    }
}
