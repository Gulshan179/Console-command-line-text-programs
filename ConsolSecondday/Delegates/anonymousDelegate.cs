using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Delegates
{
    delegate int PointFunction(int num1, int num2);
    class anonysmousDelegatte
    {
        static void Main(string[] args)
        {
            PointFunction ptaf = delegate (int num1, int num2)
            {
                return num1 * num2;
                //return num1 - num2;
                // return num1 + num2;
                // return num1 / num2;
            };//SEMICOLON IS IMPORTANT
            Console.WriteLine(ptaf(2, 2));
            Console.ReadLine();
        }
    }
}
