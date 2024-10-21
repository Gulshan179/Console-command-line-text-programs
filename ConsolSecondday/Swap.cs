using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
     class Swap
    {
        static void Main(string[] args)
        {
            int a=10, b=20;
            a = a + b;//30  =10+20
            b = a - b;//10=30-20
            a = a - b;//20=30-10
            Console.WriteLine("A value is{0}", a);
            Console.WriteLine("B value is {0}",b);
            Console.ReadLine();
        }
    }
}
