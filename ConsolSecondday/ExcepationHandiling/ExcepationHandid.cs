using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.ExcepationHandid
{
    /* class ExcepationCheck1
     {
          static void Main(string[] args)
         {
         
             string text = null;
             int length = text.Length;
             Console.WriteLine(length);
             Console.WriteLine(length);
             Console.ReadLine();

         
     }*/
    class ExcepationCheck2
    {
        static void Main(string[] args)
        {
            
                string text = null;
                try
                {
                    int length = text.Length;
                    Console.WriteLine(length);
                    Console.ReadLine();
                }
                catch (NullReferenceException eex)
                {
                    Console.WriteLine(eex.Message);
                }
                Console.ReadLine();
            }
        
    }
}
