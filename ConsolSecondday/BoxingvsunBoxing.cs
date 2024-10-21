using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class BoxingvsunBoxing
    {
        static void Main(string[] args)
        {
            //Boxing
            float f = 20.2f;
            object o1 = f;
            int i = 10;
            object o = i;
            Console.WriteLine(o1);
            Console.WriteLine(0);

            //UnBoxing
            //int z = o;
            int z = (int)o;
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
