using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class ConstructorDemoEnd
    {
        static int x; //It is going to be initialized by static constructor
        int y;//It is going to be initialized by non-static constructor 
        //Static Constructor 
        static ConstructorDemoEnd()
        {
            ////This constructor initialized the static variable x with default value i.e. 0 
            Console.WriteLine("Static Constructor is called");

        }
        
        //Non Static Constructor 
        public ConstructorDemoEnd()
        {
            Console.WriteLine("Non-Static Constructor is Called");
        }

        //Main Method is the Entry Point for our Application Execution 

        static void Main(string[] args)
        {
            //Before Executing the body of Main Method, Static Constructor is executed
            Console.WriteLine("Main Method Body..");
            Console.ReadKey();
        }
    }
}
