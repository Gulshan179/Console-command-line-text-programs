using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class ForeachLoop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("foreach loop Sample!");
            int[] oddArray = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
            foreach (int num in oddArray)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
