using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsolSecondday
{
    internal class MethodOverloading1
    {
        public void studentInfo(int rollNo)
        {
            
            Console.WriteLine("Roll No is:{0}", rollNo);
           // rollNo=Convert.ToInt32(Console.ReadLine());
        }
        public void studentInfo(int rollNo,string name)
        {
            Console.WriteLine("Student roll number{0} and name{1}", rollNo, name);
        }
        public void studentInfo(int rollNo,string name,char sgen)
        {
            Console.WriteLine("Sttudent roll no {0}and name{1} and genderis{2}", rollNo, name, sgen);
        }
        public void studentInfo(int rollNo, string name, char sgen, string location)
        {
            Console.WriteLine("Student roll no{0} name{1},gender{2},location{3}", rollNo, name, sgen,location);

        }
        static void Main(string[] args)
        {
            MethodOverloading1 obj1 = new MethodOverloading1();
            obj1.studentInfo(23);
            /*Console.WriteLine("Student Roll ", obj1.studentInfo());*/
            obj1.studentInfo(324, "Gulshan");
            obj1.studentInfo(24, "Roshan", 'm');
            obj1.studentInfo(35, "Rishi", 'f', "Mulund");
            Console.ReadLine();
        }
    }
}
