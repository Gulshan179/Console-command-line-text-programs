using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.ExcepationHandiling
{
     class ArrayOutofRanngeException
    {
        int[] num = new int[3];
        public void Size()
        {
            try
            {
                Console.WriteLine("Enter the number:");
                for(int i=0; i<5; i++)
                {
                    num[i] = Convert.ToInt32(Console.ReadLine());
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
          
            finally
            {
                for(int i=0; i<3; i++)
                {
                    Console.WriteLine("Number is{0}", num[i]);
                }    
            }
           
        }
        static void Main(string[] args)
        {
            ArrayOutofRanngeException obj1 = new ArrayOutofRanngeException();
            obj1.Size();
            Console.ReadKey();
        }

    }
}
