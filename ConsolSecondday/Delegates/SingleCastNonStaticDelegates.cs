using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Delegates
{
    public delegate int del_Maths(int number1);
    
    class MathsNonStatic
    {//singlecast non static delegates
        public int sqrt(int number)
        {
            return number * number;
        }
        public int cube(int number)
        {
            return number * number*number;
        }

        static void Main(string[] args)
        {
            MathsNonStatic obj =new MathsNonStatic();
            del_Maths del1 = new del_Maths(obj.cube);
            int res = del1(2);
            Console.WriteLine("Cude"+res);
            del_Maths del2 = new del_Maths(obj.sqrt);
            int res1=del2(2);
            Console.WriteLine("sqrt is" + res1);
            Console.ReadLine();
        }
    }
}
