using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsolSecondday.Collections
{
    class ArrayListCollection
    {
        static void Main(string[] args)
        {
            ArrayList countries = new ArrayList(8);
            // ArrayList countries = new ArrayList();//default 8 
            // Console.WriteLine("list capacity {0} :", countries.Capacity);//show value as 0 
            countries.Add("India"); //add is using to add element in arraylist. 
                                    // Console.WriteLine("list capacity {0} :", countries.Capacity);//default is 4  after inserting only one element
            countries.Add("US");
            countries.Add("UK");
            countries.Add(34);
            string[] s = { "China", "Africa" };
            countries.AddRange(s);// multiple value at end of arraylist. 
            countries.Add(56);
            countries.Add(null);

            Console.WriteLine("Coutnries {0} :", countries.Count); // getcount of element  containted in arraylist.
             Console.WriteLine("list capacity {0} :", countries.Capacity);
            Console.WriteLine("---------display all element in array list-----");
            foreach (Object obj in countries)
            {
                Console.WriteLine("{0}", obj);
            }
            Console.WriteLine("---------------------");
            // countries.Capacity = 130; // set capacity. 
            Console.WriteLine("list capacity {0} :", countries.Capacity);
            Console.WriteLine("2nd element of countries : " + countries[2].ToString());
            Console.WriteLine("2nd element of countries : " + countries[3].ToString());
            Console.Read();
        }
    }
}