using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Linq
{
     class Demo2
    {
        public static void Main(string[] args)
        {
            var Base = 12;
            var height = 23;
            var Area = (Base * height) / 2;
            Console.WriteLine("Height of tringle is :"+height+"\nBase of the tringle ius:"+Base+"\n Area of tringle :{0}",Area);
            Console.ReadLine();

        }
    }
}
