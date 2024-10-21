using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Linq
{
     class LinqLambdaExpression
    {
        public static void Main(string[] args)
        {
            List<string> County = new List<string>();
            County.Add("India");
            County.Add("USA");
            County.Add("Austreliya");
            County.Add("Canda");
            County.Add("Russia");
            County.Add("Japan");

            IEnumerable<string> result = County.Select(x => x);
            foreach (var item in result)
            {
                Console.WriteLine(item);    

            }
            Console.ReadLine();
        }
    }
}
