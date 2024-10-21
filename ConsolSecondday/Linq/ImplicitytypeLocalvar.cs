using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Linq
{
    public class demo
    {
        public static void Main(string[] args)
        {
            //Declaring and initializing 
            var e = 50;
            var d = "Welcome Gulshan";
            var c = 340.34;
            var f = false;
            Console.WriteLine("Type of 'e' is :{0}", e.GetType());
            Console.WriteLine("Type of 'b' :{0}",d.GetType());
            Console.WriteLine("Type of 'c':{0}", c.GetType());
            Console.WriteLine("Type of 'f' :{0}", f.GetType());
            Console.ReadKey();

        }
    }
}
