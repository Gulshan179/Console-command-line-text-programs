﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class Constantsreadonly
    {
        readonly int read = 10;
        const int cons = 10;
        public Constantsreadonly()
        {
            {
                read = 500;
                read = 1000;
                read = 2000;
                // cons = 200;
            }
        }
        public void check()
        {
            Console.WriteLine("read only {0}", read);
            Console.WriteLine("const {0}", cons);
        }
        static void Main(string[] args)
        {
            Constantsreadonly c3 = new Constantsreadonly();
            c3.check();
            Console.ReadLine();
        }
    }
}
