using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.ExcepationHandiling
{
     class MulitpleCatchs
    {
        public void mulitplecathc()
        {
            Console.WriteLine("Please Engter Two number");
            try
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int result = num1 / num2;

                Console.WriteLine("{0}/{1}={2}", num1, num2, result);
            }
            catch (DivideByZeroException er)
            {
                //LogError(er)
                Console.WriteLine(er);
                Console.WriteLine("Can not divide by zero. Please try again");
            }
            catch (FormatException fx)
            {
                Console.WriteLine(fx);
                Console.WriteLine("Not a Correct Format, Please try Again");
            }
        }
        static void Main(string[] args)
        {
            MulitpleCatchs df = new MulitpleCatchs();
            df.mulitplecathc();
            Console.ReadLine(); 
        }
    }
}
