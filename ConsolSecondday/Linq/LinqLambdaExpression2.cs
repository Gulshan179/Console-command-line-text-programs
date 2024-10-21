using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Linq
{
    class LinqLambdaExpression2
    {
        public static void Main(string[] args)
        {
            int[] numbers = {1, 2,3,4,5,6,7,8,9,10};
            Console.WriteLine("Below are the even numbers");
            Console.WriteLine(numbers);
            Console.WriteLine("");
            IEnumerable<int> evennumber=numbers.Where(x=>x%2==0);
            foreach (var item in evennumber)
            {
                Console.WriteLine(item + "Is an even number");
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Below are the odd numbers");
            Console.WriteLine("");

            IEnumerable<int> oddnumber=numbers.Where(x=>x%2!=0);
            foreach(var item in oddnumber)
            {
                Console.WriteLine(item + "Is an old number");
            }
            Console.ReadLine();

        }
    }
}
