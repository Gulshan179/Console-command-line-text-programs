    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsolSecondday.Collections
    {
        class QueueCollections
        {
            static void Main(string[] args)
            {
                Queue MyQueue = new Queue();
                //enqueue suing to insert element
                MyQueue.Enqueue("First");
                MyQueue.Enqueue("Second");
                MyQueue.Enqueue("Thirds");
                MyQueue.Enqueue("Fourth");
                MyQueue.Enqueue(4);
                MyQueue.Enqueue(" ");
                Console.WriteLine("peek{0}",MyQueue.Peek());//Return the object at the beginning of queue
                Console.WriteLine("Total Count {0}", MyQueue.Count);
                Console.WriteLine("Peek{0}", MyQueue.Peek());
                Console.WriteLine("Peeks{0}", MyQueue.Contains(" "));
                // Console.WriteLine("Peeks {0}",MyQueue.Contains("4");
                Console.WriteLine("peek{0}", MyQueue.Contains("Third"));
                Console.WriteLine("Peek{0}", MyQueue.Contains("China"));
                Console.WriteLine("------------------Display all element in array list---------------");
                foreach(object obj in MyQueue)
                {
                    Console.WriteLine("{0}",obj);
                }
                Console.ReadLine();


            }
        }
    }
