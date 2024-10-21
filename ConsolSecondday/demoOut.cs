using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class demoOut
    {//Out:- WHEN UR METHOD WANT TO RETURN MORE THEN 
     //ONE VALUE THEN USE OUT PARAMETER
        public static void  calculate( int fn, int sn, out int sum,out int sub)
        {
            sum = fn + sn;
            sub = fn - sn;

        }
        static void Main(string[] args)
        {
            int Addition, subtraction;
            calculate(10,20,out Addition,out subtraction);
            Console.WriteLine("Sum={0}", Addition);
            Console.WriteLine("Sum{0} && sub{1}", Addition, subtraction);
            Console.ReadLine();
            
        }
    }
}
