using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Delegates
{
    public delegate void mulitcastdel(int x, int y);
    class multicastdelegate
    {
        public static void add(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void sub(int q, int r)
        {
            Console.WriteLine(q - r);
        }
        public static void mult(int v, int w)
        {
            Console.WriteLine(v*w);
        }
        public static void div(int n1, int n2)
        {
            Console.WriteLine(n1/n2);
        }
       
        static void Main(string[] args)
        {
            mulitcastdel dd = add;
            dd += sub;
            dd += div;
            dd += mult;
            dd(20, 10);

            dd -= sub;
            dd(20, 10);

            dd -= mult;
            dd(20, 10);

            dd -= add;
            dd(20, 10);

            Console.ReadLine();
        }
    }
}
