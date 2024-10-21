using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    public class SealedClass
    {
        public void Display()
        {
            Console.WriteLine("This is a Sealed class which can't be further inherited");
        }
    }
    sealed class sealedderived:SealedClass
    {
        
    }
    /*class sealedderived2 : sealedderived
    {

    }*/

    class sealedmain
    {
        static void Main(string[] args) 
        {
            SealedClass c = new SealedClass();
            c.Display();
            Console.ReadLine();
        }
    }


}
