using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class nestedstuct
    {
        struct employee
        {
            string eName;
            dtObirth  date;

        }
        struct dtObirth
        {
            public int day;
            public int month;
            public int year;
        }
        static void Main(string[] args)
        {
            /*int dd = 0, mm = 0, yy = 0;
            Console.Write("\n\n Create a nested structure and stire data in an array: \n");
            Console.WriteLine("=========================================================");
            employee[] emp = new employee[2];
            for(int i=0; i < 2; i++)
            {
                Console.Write("Name if the employee");
                string nm = Console.ReadLine();
                *//* emp[i].eName = nm;*//*

                Console.WriteLine("Input day of birth");
                dd = Convert.ToInt32(Console.ReadLine());
                


            }*/
        }
    }
}
