using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class Calculate
    {
        static void Main(string[] args)
        {// Program To Calculate the Simple Interest in C# 

            int P, T;
            float R, SI;
            Console.Write("Enter Amount :");
            P=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Rate");
            R=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Time");
            T = Convert.ToInt32(Console.ReadLine());
            SI = P * R * T / 100;
            Console.WriteLine("Intrest", SI);
            Console.ReadLine();
        }
    }
}
