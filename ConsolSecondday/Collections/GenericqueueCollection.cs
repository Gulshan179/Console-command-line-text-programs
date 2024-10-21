using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsolSecondday.Collections
{
     class GenericqueueCollection
    {
        static void Main(string[] args)
        {

            Queue<string> queue1 = new Queue<string>();
            queue1.Enqueue("MCA");
            queue1.Enqueue("MBA");
            queue1.Enqueue("BCA");
            queue1.Enqueue("BBA");
            queue1.Enqueue("MCA");
            queue1.Enqueue("MBA");
            queue1.Enqueue("BCA");
            queue1.Enqueue("BBA");
            Console.WriteLine("The elements in the queue are:");
            foreach (string s in queue1)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Number of elements in queue1:" + queue1.Count());
            queue1.Dequeue();//Removes the first element that enter in the queue here the first element is MCA
             queue1.Dequeue();//Removes MBA 
            Console.WriteLine("After removal the elements in the queue are:");
            foreach (string s in queue1)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Number of elements in queue1:" + queue1.Count());
            Console.ReadLine();

        }
    }
}

