using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class StaticConstructor
    {
        class Example
        {
            int i;
            static int j;
            public Example()
            {
                Console.WriteLine("Default Constructor Executed");
                i = 100;
            }
            static Example()
            {
                Console.WriteLine("Static Constructor Executed");
                j = 100;
            }
            public void Increment()
            {
                i++;
                j++;
            }
            public void Display()
            {
                Console.WriteLine("Value of i:" + i);
                Console.WriteLine("Value of j:" + j);

            }

        }
        class Test
        {
            static void Main(string[] args)
            {
                Example ex1=new Example();
                ex1.Increment();
                ex1.Display();

                ex1.Increment();
                ex1.Display();

                Example ex2=new Example();
                ex2.Increment();
                ex2.Display();

                ex2.Increment();
                ex2.Display();
                Console.ReadLine();



            }
        }
    }
}
