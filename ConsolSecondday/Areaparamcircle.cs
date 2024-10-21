using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class Areaparamcircle
    {//Area and Perimeter of Circle in C# Console Application 
        static void Main(string[] args)
        {
            double r, parm, area;
            Console.WriteLine("Please enter radius of circle");
            r = Convert.ToDouble(Console.ReadLine());
            parm = 2 * 3.14 * r;
            area=3.14*Math.Pow(r, 2);///area = 3.14 * r * r; 
            Console.WriteLine("The parameter of your circle{0}", parm);
            Console.WriteLine("The area of circle{0}", area);
            Console.ReadLine(); 

        }
    }
}
