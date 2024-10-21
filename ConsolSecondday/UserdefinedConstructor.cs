using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class UserdefinedConstructor
    {
       
        class employee
        {
            public int id, age;
            public string name,address;
            public bool isParament;

        }

        class test
        {


            static void Main(string[] args)
            {
                employee em = new employee();
                Console.WriteLine("Emplyee id is", em.id);
                Console.WriteLine("Emplyee Name is", em.name);
                Console.WriteLine("Emplyee address is",em.address);
                Console.WriteLine("Emplyee age is ", em.age);
                Console.WriteLine("is Emplyee is paramanete", em.isParament);
                Console.ReadLine();
            }
            
        }
        
    }
}
