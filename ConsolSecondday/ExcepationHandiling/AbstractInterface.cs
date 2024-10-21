using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.ExcepationHandiling
{
    abstract class student
    {
        public void giveattandance()
        {
            Console.WriteLine("giving attandance");
        }
        public void attandevent()
        {
            Console.WriteLine("attenting events");
        }
        public void visitlibrary()
        {
            Console.WriteLine("going to library for study");
        }


        public abstract void exam();


        public abstract void mock();

        public abstract void fees();



    }

    class festudent : student, IYoga, IDance, ISing
    {
        public void dosocialactivity()
        {
            Console.WriteLine("doing social activity");
        }

        public override void exam()
        {
            Console.WriteLine("fe exam"); 
                }

        public override void mock()
        {
            Console.WriteLine("fe mock");
        }
        public override void fees()
        {
            Console.WriteLine("fe fees");
        }


        public void dance()
        {
            Console.WriteLine("salsa");
        }
        public void sing()
        {
            Console.WriteLine("classsical");
        }
        public void yoga()
        {
            Console.WriteLine("suryanamaskar");
        }

    }
    class sestudent : student, IYoga, IDance, ISing
    {
        public void indusyrialvisit()
        {
            Console.WriteLine("indistrial visit");
        }
        public override void exam()
        {
            Console.WriteLine("se exam");
        }

        public override void mock()
        {
            Console.WriteLine("se mock");
        }
        public override void fees()
        {
            Console.WriteLine("se fees");
        }

        public void dance()
        {
            Console.WriteLine("hippop");
        }
        public void sing()
        {
            Console.WriteLine("romantic");
        }
        public void yoga()
        {
            Console.WriteLine("kapalabgarti");
        }

    }
    class testudent : student
    {
        public void palcementpreparation()
        {
            Console.WriteLine("do placement study");
        }


        public override void exam()
        {
            Console.WriteLine("te exam");
        }

        public override void mock()
        {
            Console.WriteLine("te mock");
        }
        public override void fees()
        {
            Console.WriteLine("te fees");
        }
    }
    class besstudent : student
    {
        public void doproject()
        {
            Console.WriteLine("do project study");
        }
        public override void exam()
        {
            Console.WriteLine("be exam");
        }

        public override void mock()
        {
            Console.WriteLine("be mock");
        }
        public override void fees()
        {
            Console.WriteLine("be fees");
        }

    }
    class studentinfo
    {
        public static void Main()
        {

            festudent f = new festudent();
            f.dosocialactivity();
            f.attandevent();
            f.giveattandance();
            f.visitlibrary();
            f.fees();
            f.mock();
            f.exam();

            sestudent s = new sestudent();
            s.indusyrialvisit();
            s.attandevent();
            s.giveattandance();
            s.visitlibrary();
            s.fees();
            s.mock();
            s.exam();

            testudent t = new testudent();
            t.palcementpreparation();
            t.attandevent();
            t.giveattandance();
            t.visitlibrary();
            t.fees();
            t.mock();
            t.exam();

            besstudent b = new besstudent();
            b.doproject();
            b.attandevent();
            b.giveattandance();
            b.visitlibrary();
            b.fees();
            f.mock();
            f.exam();

            Console.ReadLine();
        }
    }
}
