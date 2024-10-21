using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Collections
{
     class GenericlistCollection
    {
        static void Main(string[] args)
        {

            List<String> months = new List<String>();

            months.Add("Jan");
            months.Add("Feb");
            months.Add("Apr");
            /// months.Add(63);will show compile time error bcz 
            /// type is defined allready that is string 

            Console.WriteLine("----------------------------");
            foreach (string mon in months)
            {
                Console.WriteLine(mon);
            }
            months.Insert(2, "Mar");//inserting element at 2 position. 
            Console.WriteLine("----------------------------");
            // months.RemoveAt(2); 
            /// months.Remove("Mar"); 

            foreach (string mon in months)
            {
                Console.WriteLine(mon);
            }
            Console.WriteLine("----------------------------");
            Console.Read();
        }
    }
}
