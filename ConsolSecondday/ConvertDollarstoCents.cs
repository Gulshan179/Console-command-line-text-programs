using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class ConvertDollarstoCents
    {//Convert Dollars to Cents
        static void Main(string[] args)
        {
            double Doller_amount;
            int cents;
            Console.WriteLine("Enter Doller amount");
            Doller_amount= Convert.ToDouble(Console.ReadLine());    
            cents=(int)(Doller_amount*100);
            Console.WriteLine("{0}$={1}¢", Doller_amount, cents);
            Console.ReadLine();

        }
        static int cents(double Doller_amount)
        {
            return (int)(Doller_amount * 100);
        }
    }
}
