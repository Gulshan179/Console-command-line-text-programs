using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Linq
{
    class Student2
    {
        public int id { get;set; }
        public string name { get;set; } 
        public string Email { get;set; }
    }
    class SwitchDirectionAndOrientaion
    {
        public static void Main(string[] args)
        {
            Student2 stud = new Student2 { id = 101, name = "Gulshan Chauhan", Email = "gulasan@gmail.com" };
            Console.WriteLine(stud.id);
            Console.WriteLine(stud.name);
            Console.WriteLine(stud.Email);
            Console.ReadLine();
        }
    }
}
