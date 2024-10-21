    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsolSecondday.ExcepationHandiling
    {
        class DivideByZeroExceptione
        {
            int res = 0, a, b;
            public void Division()
            {
                try
                {
                    Console.WriteLine("Enter 1 Number");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2 Number");
                    b = Convert.ToInt32(Console.ReadLine());
                    res = a / b;
                }
                catch(DivideByZeroException de)
                {
                    Console.WriteLine(de.ToString());
                }
                catch(Exception ex) 
                { 
                    Console.WriteLine(ex.ToString());   
                }
                finally
                {
                    Console.WriteLine("Result is{0} ", res);
                }
            }
            static void Main(string[] args)
            {
                DivideByZeroExceptione bjs = new DivideByZeroExceptione();
                bjs.Division();
                Console.ReadLine();
            }
        }
    }
