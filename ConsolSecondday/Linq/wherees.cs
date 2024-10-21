using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Linq
{
    public class wherees
    {
        public static void Main(string[] args)
        {
            IList<Student7> studentList = new List<Student7>()
            {
                new Student7(){StudentID=1,StudentName="Gulshan Chauhan",Age=34},
                new Student7(){StudentID=2,StudentName="Rishi ",Age=23},
                new Student7(){StudentID=3,StudentName="Shivam ",Age=78},
                 new Student7(){StudentID=4,StudentName="Aryan",Age=38},
                  new Student7(){StudentID=5,StudentName="Sohil",Age=28},
            };
            var teenagestudent = from s in studentList where s.Age > 12 && s.Age < 20 select s;
            Console.WriteLine("Teen age Student:");
            foreach (Student7 std in teenagestudent)
            {
                Console.WriteLine(std.StudentName);
            }
        }
    }
         class Student7
        {

            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }

        }


    
}
