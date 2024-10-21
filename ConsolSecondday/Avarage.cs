using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class Avarage
    {//Program to finds the average of 3 numbers in C# 

        static void Main(string[] args)
        {
            int num1,num2,num3,avg;
            Console.WriteLine("Enter number 1 ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            num3=Convert.ToInt32(Console.ReadLine());
            avg=(num1+num2+ num3)/3;
            Console.WriteLine("avarage of three member is {0}", avg);
            Console.ReadLine();

        }
    }
}
