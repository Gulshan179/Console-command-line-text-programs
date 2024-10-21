using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class biggestofthreenumbers
    {
        static void Main(string[] args)
        {//Finding the biggest of three numbers in C# 
            int num1,num2,num3;
            string result;
            Console.WriteLine("Enter First number");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter three number");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1>num3)
            {
                result = "The 1st number is greatest amount\n";
            }
            else if(num2 > num1 && num2 > num3)
            {
                result = "The 2nd Number is the greatest among three \n";
            }
            else
            {
                result = "The 3rd Number is the greatest among three \n";
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
