using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class Arraystruct
    {
        struct student
        {
            public int sid;
            public string sname, cname, dob;
        }
        static void Main(string[] args)
        {
            student[] arr = new student[4];
            Console.WriteLine("For taking values");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Please enter Studeid,studentname,courcename,dateofbirth,");
                arr[i].sid = Int32.Parse(Console.ReadLine());
                arr[i].sname = Console.ReadLine();
                arr[i].cname = Console.ReadLine();
                arr[i].dob = Console.ReadLine();
            }
            Console.WriteLine("For displaying values");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Studengt of {0}", arr[i].sid);
                Console.WriteLine("Student of {0}:", arr[i].sname);
                Console.WriteLine("Course name is {0}", arr[i].cname);
                Console.WriteLine("Date of Birth  {0}:", arr[i].dob);
            }
            Console.ReadLine();

        }
    }
}
