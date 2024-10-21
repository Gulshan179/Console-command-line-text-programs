using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class demonullable
    {
        static void Main(string[] args)
        {
            //char c = null;
            //float b = null;
            //int a = null;
            //string name = null;
            int? num1 = null;
            int ? num2 = null;
            double? num3 = new double();
            double? num4 = 3.43;
            bool? boolval1=new bool();
            bool? boolval2 = true;
            Console.WriteLine("Nullables at show:{0},{1},{2},{3}",num1,num2,num3,num4);
            Console.WriteLine("A Double at value{0},\n{1}", num3, num4);
            Console.WriteLine("A Nullable boolean vale{0}",boolval1);
            Console.WriteLine("A  nullable Boolean value{0}", boolval2);
            Console.ReadKey();

        }
    }
}
