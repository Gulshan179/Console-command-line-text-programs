using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class Factorial
    {//# Program to Find the Factorial of a Number 
        static void Main(string[] args)
        {
            int i, num, fact;
            Console.WriteLine("Enter The number");
            num=Convert.ToInt32(Console.ReadLine());
            fact = num;
            for(i=num-1;i>1; i-- )
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial Number is given{0}"+ fact);
            Console.ReadLine();
        }
    }
}
