using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
   public partial class partialclass
    {
        private int x;
        private int y;

        public partialclass(int x,int y)
        {
            this.x = x;
            this.y = y;

        }
    }
    public partial class partialclass 
    {
        public void PrintCordnates()
        {
            Console.WriteLine("Output values:{0}{1}", x, y);
        }
    }

    class partialClasstest
    {
        static void Main(string[] args) 
        {
            partialclass p = new partialclass(10, 15);
            p.PrintCordnates();
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
