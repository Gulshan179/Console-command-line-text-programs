using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class Squareparameter
    {//Square Area and Perimeter Calculator 
        static void Main(string[] args)
        {
            int squa, area, perma;
            Console.WriteLine("What is the height of your square? :");
            squa=Convert.ToInt32(Console.ReadLine());
            area = squa * squa;
            perma = 4 * squa;
            Console.WriteLine("area{0}\nparametere\n{1},", area, perma);
            Console.ReadKey();

        }
    }
}
