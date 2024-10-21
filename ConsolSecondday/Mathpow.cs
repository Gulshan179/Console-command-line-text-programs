using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class Mathpow
    {
        static void Main(string[] args)
        {//C# Math.Pow Exampl
            double bsnum, pwnum, returnNumber;
            Console.WriteLine("Enter Base number");
            bsnum =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Expanded number");
            pwnum = Convert.ToDouble(Console.ReadLine());
            returnNumber=Math.Pow(pwnum, bsnum);
            Console.WriteLine("{0}^{1}={2}", bsnum, pwnum, returnNumber);
            Console.ReadKey();

        }
    }
}
