using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class MethodOverloading
    {
        public void add(int n1,int n2)
        {
            Console.WriteLine("Addition :{0}",n1+n2);
        }
        public void add(float n1,float n2)
        {
            Console.WriteLine("Addition :{0}", n1 + n2);
        }
        public void add(int n1,int n2,int n3)
        {
            int sum;
            sum=n1+n2+n3;
            Console.WriteLine("Addition of Sum:{0}", sum);
        }
        static void Main(string[] args)
        {
            MethodOverloading obj=new MethodOverloading(); 
            obj.add(1,2);
            obj.add(2.4f, 3.5f);
            obj.add(1, 5, 6);
            Console.ReadLine();
        }
    }
}
