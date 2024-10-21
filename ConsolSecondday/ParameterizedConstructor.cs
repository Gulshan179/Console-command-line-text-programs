using ConsolSecondday;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsolSecondday
{

    class Employee
    {
        public int id, age;
        public string name, address;
        public bool isParament;
        public Employee()
        {
            id = 100;
            age = 30;
            address = "Bhubaneswar";
            name = "Anurag";
            isParament = true;
        }
        public void Display()
        {
           
            Console.WriteLine("Emplyee id is" +id);
            Console.WriteLine("Emplyee Name is"+name);
            Console.WriteLine("Emplyee address is"+address);
            Console.WriteLine("Emplyee age is "+age);
            Console.WriteLine("is Emplyee is paramanete"+isParament);
        }
    }
    internal class ParameterizedConstructor
    {
        class program
        {
            static void Main(string[] args)
            {
                Employee nw = new Employee();
                nw.Display();


                Employee e2 = new Employee();
                Console.WriteLine();
                e2.Display();
                Console.ReadLine();
            }
        }
    }

}
