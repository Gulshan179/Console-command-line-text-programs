using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class greatervalues
    {
        static void Main()
        {
            int a = 1;
            int b = 2;
            bool greatAb = (a < b);
            bool equalA1 = (a == 1);
            if (greatAb)
            {
                Console.WriteLine("a>b");
            }
            else
            {
                Console.WriteLine("a==b");
            }

            Console.ReadLine();
        }
    }
}
