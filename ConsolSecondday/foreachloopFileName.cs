using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class foreachloopFileName
    {
        static void Main(string[] args)
        {
            string[] arr = new string[5];
            arr[0] = "jack";
            arr[1] = "uk";
            arr[2] = "101";
            arr[3] = "10.10f";
            arr[4] = "pass";
            foreach(string info in arr)
            {
                Console.WriteLine(info);    
            }
            Console.ReadLine();
        }
    }
}
