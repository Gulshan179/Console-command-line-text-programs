using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Tuples
{
     class AccessingTuple
    {
        public static void Main(string[] args)
        {
            var person = Tuple.Create(1, "Steve", "Jobs");
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);
            Console.WriteLine(person.Item3);

            var number = Tuple.Create("One", 2, 3, "Four", 5, "Six", 7, 8);
            Console.WriteLine(number.Item1);
            Console.WriteLine(number.Item2);
            Console.WriteLine(number.Item3);
            Console.WriteLine(number.Item4);
            Console.WriteLine(number.Item5);
            Console.WriteLine(number.Item6);
            Console.WriteLine(number.Item7);
            Console.WriteLine(number.Rest);
            Console.WriteLine(number.Rest.Item1);
            Console.ReadLine();

        }
    }
}
