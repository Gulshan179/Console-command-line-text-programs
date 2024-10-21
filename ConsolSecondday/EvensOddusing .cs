using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class EvensOddusing
    {//Find Number is Even or Odd using if else Statement in C# 
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter integer");
            n=Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("{0}is Even ", n);

            }
            else
            {
                Console.WriteLine("{0} is odd", n);

            }
            Console.ReadKey();
        }
    }
}
