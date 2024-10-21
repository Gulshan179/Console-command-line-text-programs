using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class Jaggedarray
    {
        static void Main(string[] args)
        {
            string[] empname = new string[3];
            empname[0] = "pooja";
            empname[1] = "Rekha";
            empname[2] = "Vivek";

            string[][] empskills=new string[3][];
            empskills[0] = new string[4];
            empskills[1] = new string[1];
            empskills[2] = new string[3];

            empskills[0][0] = "bachelor";
            empskills[0][1] = "master";
            empskills[0][2] = "doctorate";
            empskills[0][3] = "mba";

            empskills[1][0] = "Bachelor";

            empskills[2][0] = "bachelor";
            empskills[2][1] = "master";
            empskills[2][2] = "testing";
            for(int i = 0;i< empskills.Length; i++)
            {
                Console.WriteLine(empname[i]);
                Console.WriteLine("=========================");
                string[] innerarray = empskills[i];
                for(int j=0; j<innerarray.Length;j++)
                {
                    Console.WriteLine(innerarray[j]);
                }
                Console.ReadLine();

            }
            Console.ReadLine();
        }
    }
}
