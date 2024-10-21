using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class Boxingunboxing
    {
        static void Main(string[] args)
        {
            //boxing
            float f = 10.2f;
            object o1 = f;
            int i = 10;
            object o = i;
            Console.WriteLine(o1);
            Console.WriteLine(o);
            // unboxing 
            // int z = o;
            int z = (int)o;
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
