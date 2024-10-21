using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsolSecondday.ExcepationHandiling
{

    class ExpationCreateUser
    {
        static void Main(string[] args)
        {
            int acceptorder;
            Console.WriteLine("Welcome to shopping site\nHow Many headphone you want to buy ");
            acceptorder = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (acceptorder == 10 || acceptorder < 10)
                {
                    Console.WriteLine("Congratulation! Yoy have bought {0} headphones", acceptorder);
                    Console.ReadLine();

                }
                else
                {
                    throw (new OutofStockException("OutofStockException Generated :The number of item you want to buy us out of stock.Please enter total item number within stock"));

                }
            }
            catch (OutofStockException ose)
            {
                Console.WriteLine(ose.Message.ToString());
                Console.ReadLine();
            }

        }
    }
    public class OutofStockException : Exception
    {
        public OutofStockException(string message)
        : base(message)
        {
        }
    }
}