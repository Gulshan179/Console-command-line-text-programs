using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class StaticnonstaticMember
    {
        int roll_no;
        string name;
        static string college = "VPM RZ";
        public StaticnonstaticMember(int r,string n)
        {
            roll_no = r;
            name = n;
        }

        public void Dis()
        {
            Console.WriteLine(roll_no + "" + name + "" + college + "");
        }
        static void Main(string[] args)
        {
            StaticnonstaticMember ST1 = new StaticnonstaticMember(111, "\tGulshan");
            StaticnonstaticMember ST2 = new StaticnonstaticMember(112, "\tSayali");
            StaticnonstaticMember ST3 = new StaticnonstaticMember(113, " Ajit");
            ST1.Dis();
            ST2.Dis();
            ST3.Dis();
            Console.ReadLine();
        }
    }
}
