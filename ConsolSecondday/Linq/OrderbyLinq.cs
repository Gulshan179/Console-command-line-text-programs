using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Linq
{
    public class OrderbyLinq
    {
        public static void Main(string[] args)
        {
            IList<Student9> studlist = new List<Student9>()
            {
                new Student9(){studid=1,studname="Gulshan",age=23},
                new Student9(){studid=2,studname="Shivam",age=24},
                new Student9(){studid=3,studname="Bhargav",age=25},
                new Student9(){studid=4,studname="Sudhaker",age=26},
                new Student9(){studid=5,studname="Rishi",age=27},
                new Student9(){studid=6,studname="Pratik",age=28},
            };
            var orderByResult = from s in studlist orderby s.studname select s;
            var orderbyDesecendingreReult = from s in studlist orderby s.studname descending select s;
            Console.WriteLine("Ascending Order");
            foreach (var std in orderByResult)
            {
                Console.WriteLine(std.studname);

            }
            Console.WriteLine("Descending Order");
            foreach (var std in orderbyDesecendingreReult)
            {
                Console.WriteLine(std.studname);
            }

        }


        public class Student9
        {
            public int studid { get; set; }
            public string studname { get; set; }
            public int age { get; set; }

        }
    }
}
