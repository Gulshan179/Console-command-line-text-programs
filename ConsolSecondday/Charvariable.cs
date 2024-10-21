using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class Charvariable
    {
        static void Main()
        {
            int[] x = { 3, 5, 6, 34, 6, 3, 23, 89, 32, 34, 3, 45 };
            Console.WriteLine("hash code of array x " + x.GetHashCode());
            Console.WriteLine("Average of element in x " + x.Average());
            Console.WriteLine("Sum of element in x " + x.Sum());
            Console.WriteLine("Maxixum element in x " + x.Max());
            Console.WriteLine("Minimum of element in x" + x.Min());
            Console.WriteLine("Length" + x.GetHashCode());
            Console.WriteLine("Lower Bound" + x.GetLowerBound(0));
            Console.WriteLine("Upper Bound" + x.GetUpperBound(0));

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
            Console.ReadLine();

        }
    }
}
