using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class CountNumberofWords
    {
        static void Main(string[] args)
        {
            string sentance;
            Console.WriteLine("Enter String");
            sentance = Console.ReadLine();
            string[] words = sentance.Split();
            Console.WriteLine("Count of Word :" + words.Length);
            Console.ReadLine();
        }
    }
}
