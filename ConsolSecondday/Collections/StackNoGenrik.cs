using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Collections
{
     class StackNoGenrik

    {
        static void Main(string[] args)
        {
            Stack numStack = new Stack();
            numStack.Push(20);
            numStack.Push(23);
            numStack.Push(24);
            numStack.Push(88);
            numStack.Push(null);
            numStack.Push(1.2);
            numStack.Push('e');
            numStack.Push("Gulshan");
            Console.WriteLine(numStack.Peek());

            Console.WriteLine("Count:" + numStack.Count);
            Console.WriteLine("Element removed is {0}", numStack.Pop());
            Console.WriteLine(numStack.Peek());
            Console.WriteLine(numStack.Count);
            Console.WriteLine("------------------------Display Element-------------------");
            foreach(Object obj in numStack)
            {
                Console.WriteLine("{0}",obj);
            }

            Console.ReadLine();
        }

    }
}
