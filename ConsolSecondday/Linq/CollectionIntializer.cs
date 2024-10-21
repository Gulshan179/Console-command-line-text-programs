using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Linq
{
    class student3
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    class ObjectInitaializer1
    {
        public static void Main(string[] args)
        {
            List<student3> stud1 = new List<student3>
            {
                new student3 { ID = 101,Name="Gulshan Chauhan",Email="gulashan179@gmail.com"},
                new student3{ID=102,Name="Shivam Chaursiya",Email="shiva88@gmail.com"},
                new student3{ID=103,Name="Bhargav Yadav",Email="bhargav678@gmail.com"}

            };
            foreach (student3 student in stud1)
            {
                Console.WriteLine(student.ID);
                Console.WriteLine(student.Name);
                Console.WriteLine(student.Email);
                Console.ReadLine();
            }
        }
    }
}
