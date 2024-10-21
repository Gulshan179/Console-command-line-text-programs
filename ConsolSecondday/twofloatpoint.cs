using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class twofloatpoint
    {//Multiply Two Floating Point Numbers in C# Console 

        static void Main(string[] args)
        {
            float num1, num2, product;
            num1 = 23.4f;
            num2 = 324.03f;
            product = num1 * num2;
            Console.WriteLine("{0} is {1} ={2}", num1, num2, product);
            Console.ReadLine();

        }
    }
}

