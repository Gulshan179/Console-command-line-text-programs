using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class Methodz
    {
        void add(int x, int y)
        {
            Console.WriteLine("addition is {0}", x + y);
        }
        void sub(int p, int q)
        {
            Console.WriteLine("substraction is {0}", p - q);
        }
        void div(int s, int z)
        {
            Console.WriteLine("division is {0}", s - z);
        }
        void mul(int r, int a)
        {
            Console.WriteLine("multiplication is {0}", r * a);
        }

        static void Main(string[] args)
        {
            Methodz c = new Methodz();
            c.add(10, 20);
            c.div(10, 5);
            c.mul(5, 5);
            c.sub(10, 10);
            Console.ReadLine();

        }
    }
}
