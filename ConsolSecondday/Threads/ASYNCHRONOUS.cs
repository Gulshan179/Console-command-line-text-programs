using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsolSecondday.Threads
{
    class Class2
    {
        static void test1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("test1 :-" + i);
            }
        }
        static void test2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("test2 :-" + i);
                if (i == 50)
                {
                    Console.WriteLine("main thread is going to sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("main thread is woke up ");
                }
            }
        }
        static void test3()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("test3 :-" + i);
            }
        }
        static void Main(string[] args)
        {

            Thread t1 = new Thread(test1);
            Thread t2 = new Thread(test2);
            Thread t3 = new Thread(test3);
            //now run 
            //second time u need to start
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadLine();

            Thread t4 = new Thread(new ThreadStart(test1));
            Thread t5 = new Thread(new ThreadStart(test2));
            Thread t6 = new Thread(new ThreadStart(test3));
            t4.Start();
            t5.Start();
            t6.Start();
        }
    }
}

