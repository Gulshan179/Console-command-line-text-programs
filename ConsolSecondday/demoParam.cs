using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class demoParam
    {   // param is the keyword 
        //used when you do not know how many variables you will be passing across method
        //USED WHEN WE WANT TO PASS ARRAY AS AN PARAMETER
        public void show(params int[] val)
        {
            for(int i=0; i<val.Length; i++)
            {
                Console.WriteLine(val[i]);  
            }
        }
        static void Main(string[] args)
        {
            demoParam pr=new demoParam();
            pr.show(2, 3, 7, 3, 5, 5, 3, 3, 1, 7, 8, 56);
            Console.ReadLine();

        }
    }

}
