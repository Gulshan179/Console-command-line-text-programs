using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class minmaxarray
    {//program to find min and max in an array 

        static void Main(string[] args)
        {
            int[] num = new int[10];
            Random rand = new Random();
            int max, min;
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rand.Next(1, 100);
                Console.WriteLine(num[i]);
            }
            min = num[0];
            max= num[0];
            for(int i=1; i<num.Length; i++)
            {
                if (min > num[i])
                    min = num[i];
                if (max < num[i])
                    max = num[i];
             }
            Console.WriteLine("The highest number in the array:>>" + max);
            Console.WriteLine("The Lowest Number in the array:>>>"+min);
            Console.ReadLine();
        }
    }
}
