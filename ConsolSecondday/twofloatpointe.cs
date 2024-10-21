using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsolSecondday
{
    internal class twofloatpointe
    {
        //Program to Multiply two Floating Point Numbers Entered by User
        static void Main(string[] args)
        {
            float num1, num2, product;
            Console.WriteLine("Enter a number one");
            num1=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter a Number two");
            num2 = Convert.ToSingle(Console.ReadLine());
            product = num1 * num2;
            Console.WriteLine("{0} is {1} ={2}",num1,num2,product);
            Console.ReadLine();


        }

     }
}
