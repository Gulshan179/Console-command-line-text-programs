using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsolSecondday.Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create ThreadA object
            Thread threadA = new Thread(new ThreadStart(ChildThreadA));
            // Create ThreadB object
            Thread threadB = new Thread(new ThreadStart(ChildThreadB));
            // Create ThreadC object
            Thread threadC = new Thread(new ThreadStart(ChildThreadC));
            threadA.Name = "Thread A";
            threadB.Name = "Thread B";
            threadC.Name = "Thread C";
            // set highest priority of threadB
            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.AboveNormal;
            threadC.Priority = ThreadPriority.Normal;
            threadA.Start();
            threadB.Start();
            threadC.Start();
            Thread.CurrentThread.Name = "Main";
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
            }
            Console.ReadKey();
        }
        public static void ChildThreadA()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Child thread A:");
            }
        }
        public static void ChildThreadB()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Child thread B:");
            }
        }
        public static void ChildThreadC()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Child thread C:");
            }
        }
    }
}

