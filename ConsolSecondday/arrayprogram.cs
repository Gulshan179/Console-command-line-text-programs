using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class arrayprogram
    {
        static void Main(string[] args)
        {
            int[] x = { 3, 5, 6, 34, 6, 3, 23, 89, 32, 34, 3, 45 };
            Console.WriteLine("hash code of array x {0}", x.GetHashCode());
            Console.WriteLine("Average of element in x{0} ", x.Average());
            Console.WriteLine("Sum of element in x {0}", x.Sum());
            Console.WriteLine("Maxixum element in x {0}", x.Max());
            Console.WriteLine("Minimum of element in{0} x", x.Min());
            Console.WriteLine("Length{0}", x.GetHashCode());
            Console.WriteLine("Lower Bound {0}", x.GetLowerBound(0));
            Console.WriteLine("Upper Bound {0}", x.GetUpperBound(0));

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
            Console.ReadLine();
        }
    }
}
