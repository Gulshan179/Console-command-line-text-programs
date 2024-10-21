using System;

namespace ConsolSecondday
{
    internal class StaticNonStatic
    {
        static int x;
        static int y;
        int z;
        static void display()
        {
            x = 1;
            y = 1;
            //z = 1;//not allowed here
        }

        void display1()
        {
            x = 1;
            y = 1;
            z = 1;
        }

        static void Main(string[] args)
        {
            /* StaticNonStatic p = new StaticNonStatic();
             p.display();*///no need to create
            StaticNonStatic.display();
            Console.WriteLine("x={0} and y={1}", x, y);

            StaticNonStatic p1 = new StaticNonStatic();
            p1.display1();
            Console.WriteLine("x={0} and y={1}and z={2}", x, y, p1.z);
            Console.ReadLine();

        }
    }
}
