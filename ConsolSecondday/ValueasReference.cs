using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class ValueasReference
    {
        static void Square( ref int x)
        {
            x *= x;
            Console.WriteLine(x);
            System.Console.WriteLine("the value is sinside the method {0}", x);
            
        }
        static void Main(string[] args)
        {
            int n = 5;
            System.Console.WriteLine("The value before calling the method {0}", n);
            Square(ref n );
            System.Console.WriteLine("The value after calling the method {0}", n);
            Console.ReadLine();
        }
    }
}
