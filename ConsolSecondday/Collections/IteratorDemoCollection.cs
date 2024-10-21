using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Collections
{
    class IteratorDemoCollection
    {//Very most important Question
        static void Main(string[] args)


        {
            foreach (int number in EvenSequence(5, 18))
            {
                Console.WriteLine(number.ToString() + "");
            }
            Console.WriteLine();
        }
        static IEnumerable<int> EvenSequence(int fno, int lno)
        {
            for (int number = fno; number <= lno; number++)
            {
                if (number % 2 == 0)
                {
                    yield return number;
                }
            }
        }
    }
}
