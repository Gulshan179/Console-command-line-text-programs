using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Collections
{
    public class Account
    {
        //virtual method 
        public virtual void CalculateInterest(double amount)
        {
            Console.WriteLine("Interest from base account {0}", amount * 0.1);
        }
        public static void Main()
        {
            Account account = new Account();
            Account savings = new Savings();
            Account current = new Current();
            account.CalculateInterest(1000.00);
            savings.CalculateInterest(1000.00);
            current.CalculateInterest(1000.00);
        }
    }
    // Child classes that inherit the Parent Class 
    class Savings : Account
    {
        //overridden method 
        public override void CalculateInterest(double amount)
        {
            Console.WriteLine("Interest from savings account {0}", (amount * 0.04) - 10.00);
        }
    }
    class Current : Account
    {
        //overridden method 
        public override void CalculateInterest(double amount)
        {
            Console.WriteLine("Interest from current account {0} ", amount * 0.01);
        }
    }
}
