using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class NestedForLoop
    {//Nested For Loop in C# (Multiplication Table) 

        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++) 
            {
                for (int j = 0; j <= 100; j++)
                {
                    Console.WriteLine("{0}x{1} = {2}", i, j, i * j);
                    Console.WriteLine("*");
                }
                Console.WriteLine("====================");
            }
            Console.ReadKey();
        }
    }
}
