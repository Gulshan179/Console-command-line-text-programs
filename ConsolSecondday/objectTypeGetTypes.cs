using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class objectTypeGetType    
    {
        int T = 1250;
        float f=40.3f;
        char v = 'a';
        double d = 10.20;


        static void Main(string[] args)
        {
            objectTypeGetType g1 = new objectTypeGetType();
            Console.WriteLine(g1.GetHashCode());
            Console.WriteLine(g1.ToString());
            objectTypeGetType g2=new objectTypeGetType();
            Console.WriteLine(g2.GetHashCode());
            Console.WriteLine(g2.ToString());
            Console.WriteLine(g1.T.GetType());
            Console.WriteLine(g1.f.GetType());
            Console.WriteLine(g1.v.GetType());
            Console.WriteLine(g2.d.GetType());

            string s1 = "Hiii";
            string s2 = "Hii i";
            if(s1.Equals(s2))
            {
                Console.WriteLine("Is Equal");
            }
            else
            {
                Console.WriteLine("Is not Equal");

            }
            Console.WriteLine(g1.Equals(g2));
            g1 = g2;
            Console.WriteLine(g1.Equals(g2));
            Console.ReadLine();


        }
    }
}
