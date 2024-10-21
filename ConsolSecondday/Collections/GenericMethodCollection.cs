using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Collections
{
     class GenericMethodCollection
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int x = 10, y = 20;
            Console.WriteLine("before swap x:" + x + " y:" + y);
            Swap(ref x, ref y);//comapraing int 
            Console.WriteLine("after swap x:" + x + " y:" + y);
            Console.WriteLine("--------------------------");
            float f1 = 3.45f, f2 = 56.2f;
            Console.WriteLine("before swap f1:" + f1 + " f2:" + f2);
            Swap(ref f1, ref f2);//comparing float 
            Console.WriteLine("after swap f1:" + f1 + " f2:" + f2);
            Console.WriteLine("--------------------------");
            string s1 = "hi";
            string s2 = "Hello";
            Console.WriteLine("before swap s1:" + s1 + " s2:" + s2);
            Swap(ref s1, ref s2);// compareing two strings 
            Console.WriteLine("after swap s1:" + s1 + " s2:" + s2);
            Console.Read();
        }
    }
}
