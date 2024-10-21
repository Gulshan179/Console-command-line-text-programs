using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Linq
{
    public class AnonymousType
    {
        public static void Main(string[] args)
        {
            var student4 = new { id = 1, firtname = "James", lastname = "Bond" };
            Console.WriteLine(student4.id);
            Console.WriteLine(student4.firtname);   
            Console.WriteLine(student4.lastname);





            //Nested Anonymouns

            var student5 = new { id = 101, firtname = "Gulshan", lastname = "Chauhan",address=new { id = 1, city = "London", Country = "India" } };
            Console.WriteLine(student5.id);
            Console.WriteLine(student5.firtname);
            Console.WriteLine(student5.lastname);
            Console.WriteLine(student5.address);
            Console.ReadLine();
        }
    }
}
