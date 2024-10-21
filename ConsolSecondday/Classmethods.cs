using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class Classmethods
    {
        void add(int x,int y)
        {
            Console.WriteLine("Addition is{0}", x + y);
        }
        void Sub( int p, int q)
        {
            Console.WriteLine("Subtraction is{0}", p - q);
        }
        void div(int s, int z)
        {
            Console.WriteLine("Division is{0}", s / z);

        }
        void mult( int r, int a)
        {
            Console.WriteLine("Multiplication is{0}",r*a);
        }
            
        static void Main(string[] args)
        {
            Classmethods bh = new Classmethods();
            bh.Sub(1,2);
            bh.div(1,2);
            bh.mult(1,2);
            bh.Sub(1, 2);
            Console.ReadLine();
        }
    }
}

