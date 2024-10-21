using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class Asmd
    {
        static void Main()
        {
            int a = 10, b = 20;
            int c, c1, c2, c3;
            c = a + b;
            c1 = a - b;
            c2 = a * b;
            c3 = a / b;
            Console.WriteLine("Addition{0}", c);
            Console.WriteLine("Subtracction{0}", c1);
            Console.WriteLine("Multiplication{0}", c2);
            Console.WriteLine("Division{0}", c3);
            Console.ReadLine();

        }
    }
}
