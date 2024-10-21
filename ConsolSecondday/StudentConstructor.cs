using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class StudentConstructor
    {
        string college_name;
        string branchCode, Sname;
        int rollNo;
        int Totalstudent;
        float Sage;
        char Sgen;

        public StudentConstructor()
        {//Only 1 Default Constructor
            college_name = "VPM RZ SHAH";
            branchCode = "12b";
            Totalstudent = 200;
        }
        public StudentConstructor(string sn, int rn,float ag,char sg)
        {
            Sname = sn;
            rollNo=rn;
            Sage =ag;
            Sgen=sg;

        }
        public StudentConstructor(String sn,int rn, float ag)
        {
            Sname = sn;
            rollNo=rn; 
            Sage =ag;

        }
        public StudentConstructor(string sn,int rn)
        {
            Sname = sn;
            rollNo = rn;

        }
        public StudentConstructor(string sn)
        {
            Sname = sn;
        }
        public void display()
        {
            Console.WriteLine("College Name{0}", college_name);
            Console.WriteLine("College Branch Code{0}",branchCode);
            Console.WriteLine("Student Name{0}", Sname);
            Console.WriteLine("Student Roll no{0}", rollNo);
            Console.WriteLine("Student Total{0}", Totalstudent);
            Console.WriteLine("Student Age{0}", Sage);
            Console.WriteLine("Student Gender{0}", Sgen);

        }
        ~StudentConstructor()//desctructor call implicity by system
        {
            Console.WriteLine("An  Instance  Destroyed");
            Console.ReadKey();
        }
        class MainStudentConstructor
        {


            static void Main(string[] args)
            {
                StudentConstructor s1 = new StudentConstructor();////it will call default constructor
                Console.WriteLine("---------------this is default constructor --------------------");
                s1.display();

                Console.WriteLine("---------------this is 1 paramiterized --------------------");
                StudentConstructor s2 = new StudentConstructor("Gulshan", 101, 20.3f, 'm');//
                s2.display();

                Console.WriteLine("---------------this is 2 paramiterized--------------------");
                StudentConstructor s3 = new StudentConstructor("ravi", 102, 23.3f);
                s3.display();

                Console.WriteLine("---------------this is 3 paramiterized--------------------");
                StudentConstructor s4 = new StudentConstructor("Roshan", 103);
                s4.display();

                Console.WriteLine("---------------this is 4 paramiterized--------------------");
                StudentConstructor s5 = new StudentConstructor("Amhesh");
                s4.display();

                Console.ReadKey();

            }
        }
    }
}
