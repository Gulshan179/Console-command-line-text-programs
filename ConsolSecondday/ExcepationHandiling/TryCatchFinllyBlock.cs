using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.ExcepationHandiling
{
     class TryCatchFinllyBlock
    {
        static void Main(string[] args)
        {
            // Llabel;

           /* int a = 10;
            int b = 20;
            a = a + b;//30
            b = a - b;//10
            a = a - b;//20*/

            try
            {
                int num1, num2;
                decimal result;
                Console.WriteLine("Divide Program.You Enter 2 Number and we return result");
                Console.WriteLine("Enter 1st Number");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number");
                num2 = Convert.ToInt32(Console.ReadLine());
                result = (decimal)num1 / (decimal)num2;
                Console.WriteLine("Divide:" + result.ToString());
                Console.ReadLine();
            }
            catch(DivideByZeroException ex) 
            {
                Console.WriteLine("You have Entered 0");
                Console.WriteLine("More Details about error:\n \n "+ex.ToString());
               // goto label;
            }
            catch(FormatException fx)
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("More Details about Error:\n\n "+fx.ToString());
                //goto label;
            }
            //parent Exception :catch all type of exception
            catch(Exception ex)
            {
                Console.WriteLine("Other Execption raised" + ex.ToString());
                //goto lablel;
            }
            finally
            {
                Console.WriteLine("Finally block:For Continue Press Enter and for exits press Ctrl+c");
                Console.ReadLine();
            }

        }
    }
}
