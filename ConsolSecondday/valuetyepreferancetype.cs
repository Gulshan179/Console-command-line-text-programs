    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsolSecondday
    {
        internal class valuetyepreferancetype
        {
            static void Change(int x)
            {
                x = 200;
                Console.WriteLine(x);
            }
            static void Main(string[] args)
            {
                int i = 100;
                Console.WriteLine(i);
                Change(i);
                Console.WriteLine(i);

                Console.ReadLine(); 
            }
        }
    }
