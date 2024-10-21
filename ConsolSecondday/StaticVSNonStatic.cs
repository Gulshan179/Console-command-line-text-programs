using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class StaticVSNonStatic
    {
        int roll_no;
        string name;
        static string collage = "iit";
        //  string collage;
        public StaticVSNonStatic(int rn, string n, string cl)
        {
            roll_no = rn;
            name = n;
            collage = cl;

        }
        public StaticVSNonStatic(int rn, string n)
        {
            roll_no = rn;
            name = n;   
        }
        public void display()
        {
            Console.WriteLine(roll_no + " " + name + " " + collage);

        }
        class MainStaticvsNonstatic
        {


            static void Main(string[] args)
            {
                /*StaticVSNonStatic s1 = new StaticVSNonStatic(111, "deepti", "iit");
                StaticVSNonStatic s2 = new StaticVSNonStatic(112, "sayali", "iit");
                StaticVSNonStatic s3 = new StaticVSNonStatic(113, "ajit", "iit");*/

                StaticVSNonStatic s1 = new StaticVSNonStatic(111, "deepti");
                StaticVSNonStatic s2 = new StaticVSNonStatic(112, "sayali");
                StaticVSNonStatic s3 = new StaticVSNonStatic(113, "ajit");

                s1.display();
                s2.display();
                s3.display();
                Console.ReadLine();
            }
        }
    }
}
