using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Delegates
{
  public delegate void delegeneric <T>(T value);
    class delegenric
    {
        public void getValue<T>(T vale) 
        {
            Console.WriteLine("Value is:" +vale);
        }

        static void Main(string[] args)
        {
            delegenric  vgi=new delegenric();
            delegeneric<string> di=new delegeneric<string>(vgi.getValue);
            di("Raj");
            delegeneric<int> di1=new delegeneric<int> (vgi.getValue);
            di1(10);
            Console.ReadLine();
        }
    }
}