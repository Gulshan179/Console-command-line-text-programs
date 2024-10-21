using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    static class Author 
    {
        public static string aname = "ANKIT";
        public static string lNAME = "Chsarp";
        public static int T_no = 54;

        public static void details()
        {
            Console.WriteLine("The details of Authoer is");
        }
    }
    public class StaticAuthor
    {
        static public void Main(string[] args)
        {
            Author.details();
            Console.WriteLine("Author first name:{0}", Author.aname);
            Console.WriteLine("Author last name:{0}", Author.lNAME);
            Console.WriteLine("Total number of articles{0}", Author.T_no);

            Console.ReadLine();
            
        }
    }
}
