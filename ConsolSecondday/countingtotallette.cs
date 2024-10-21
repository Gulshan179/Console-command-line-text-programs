using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class countingtotallette
    {//Counting program the total letter in text in C# Console 
        /*static void Main(string[] args)
        {
            string myst=Console.ReadLine();
            int count = 0;
            for( int i = 0; i < myst.Length; i++ )
            {// check the char for whitespace.  If char is not whitespace, increase the count variable 
                if (!char.IsWhiteSpace(myst[i]))
                {
                    count++;
                }

            }
            Console.WriteLine("Tot"+count);
            Console.ReadLine();
        }*/
        static void Main(string[] args)
        {
            Console.Write("Enter string :");
            string myString = Console.ReadLine();
            int count = 0;

            foreach (char item in myString)
            {
                // check the char for whitespace.  If char is not whitespace, increase the count variable 
                if (!char.IsWhiteSpace(item))
                {
                    count++;
                }
            }

            Console.WriteLine("Total letters: " + count);
            Console.ReadLine();
        }

    }
}
