using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Delegates
{
    public delegate int del_Math(int number1);
    class maths
    {//singlecast static delegates 
        static public int sqrt(int number)
        {
            return number * number;
        }
        static public int cube(int number)
        {
            return number * number * number;
        }
        static void Main(string[] args)
        {
            del_Math del3 = new del_Math(maths.sqrt);
            int res = del3(2);
            Console.WriteLine("cube is" + res);
            Console.ReadLine();
        }
    }
}
