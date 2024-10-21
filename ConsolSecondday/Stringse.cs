using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class Stringse
    {
        static void Main(string[] args)
        {
            string str1 = "Dot net Tutorial";
            string str2 = @"Dot net Tutorial";
            string str3 = "Dot \n net \t Tutorial";
            string str4 = @"Dot \nNet \t tutorial";
            Console.WriteLine($"str1:{str1}");
            Console.WriteLine($"str2:{str2}");
            Console.WriteLine($"str3:{str3}");
            Console.WriteLine($"str3:{str4}");
            Console.ReadKey();
        }
    }
}
