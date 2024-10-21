using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Linq
{
     class LinqQueryReturnAnonymous
    {
        public static void Main(string[] args)
        {
            IList<Student5> studentlist = new List<Student5>()
            {
                new Student5(){studid=11,studname="Gulshan Chauhan",age=23},
                new Student5(){studid=12,studname="Bhargav Yadav",age=25},
                new Student5(){studid=13,studname="Shivam",age=27},
                new Student5(){studid=14,studname="Rishi Yadav",age=28},
                new Student5(){studid=15,studname="Mahir bhan",age=24},
                new Student5(){studid=16,studname="Shubham",age=37},
            };
            var student6 = from s in studentlist select new {id=s.studid,name=s.studname};
            foreach ( var stud in student6 ) 
            {
                Console.WriteLine(stud.id+"_"+stud.name);
            }
            Console.ReadLine();

        }
        class Student5 
        {
            public int studid { get;set; }
            public string studname { get;set; } 
            public int age { get;set; }  
            
        }
    }
}
