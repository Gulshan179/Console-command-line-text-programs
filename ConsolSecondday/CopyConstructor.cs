using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class CopyConstructor
    {
        class Employee
        {
            public int id, age;
            public string name, address;
            public bool isParament;

            public Employee(int id, int age, string address, string name,  bool isParament) 
            {
                id = id;
                age = age;
                address = address;
                name = name;
                isParament = isParament;
                
            }
            public Employee(Employee emp)
            {
                id=emp.id;
                age=emp.age;
                address = emp.address;
                name =emp.name;
                isParament=emp.isParament;
            }

            public void Display()
            {
                Console.WriteLine("Emplyee id is" + id);
                Console.WriteLine("Emplyee age is " + age);
                Console.WriteLine("Emplyee address is" + address);
                Console.WriteLine("Emplyee Name is" + name);
                Console.WriteLine("is Emplyee is paramanete" + isParament);

            }


        }

        static void Main(string[] args)
        {
            Employee e1 = new Employee(101, 24, "Gulshan Chauhan", "Mumbai", true);
            e1.Display();
            Console.WriteLine();


            //Employee e2 = new Employee(102, 234, "Roshan Chauhan", "Thane", false);
            Employee e2 = new Employee(e1);
            e2.Display();
            Console.ReadLine();

        }
    }
}
