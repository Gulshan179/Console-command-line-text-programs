using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class stringStringbuilder
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            Console.WriteLine(str);
            str = str + "To all";
            Console.WriteLine(str);
            str = str + "Hi";
            Console.WriteLine(str);
            
            StringBuilder sb= new StringBuilder("India");
            sb = sb.Append("vs");
            sb = sb.Append("Austrelia");
            Console.WriteLine(sb);
            sb = sb.Insert(5, "");
            sb = sb.Insert(8, "");
            Console.WriteLine(sb);
            Console.WriteLine(sb.Length);
            Console.ReadLine();
        }
    }
}
