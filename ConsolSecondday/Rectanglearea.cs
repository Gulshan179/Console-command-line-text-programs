using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class Rectanglearea
    {//Calculate Rectangle Area 
        static void Main(string[] args)
        {
            int area, length, width;
            Console.WriteLine("Please write  the length of Your rectangle");
            length=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write the width of your rectangle");
            width=Convert.ToInt32(Console.ReadLine());  
            area=length*width;
            Console.WriteLine("The Area of Rectangle:-\t", area);
            Console.ReadLine();
        }
    }
}
