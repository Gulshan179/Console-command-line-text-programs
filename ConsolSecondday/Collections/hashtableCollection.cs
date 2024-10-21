using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Collections
{
    class hashtableCollection
    {
        static void Main(string[] args)
        {
            Hashtable hDay = new Hashtable();
            hDay.Add("1", "Monday");
            hDay.Add("2", "Tuesday");
            hDay.Add("3", "Wendesday");
            hDay.Add("4", "Thursday");
            // hDay.Add(null, "Thursday");
            //hDay.Add("4", "Thursday1234"); // error hashtable conatain unique key value. 
            hDay.Add("five", null);
            hDay.Add("six", "Friday");
            hDay.Add(6, "Friday");// 6 is considered as diffrent key. 
            Console.WriteLine("-------------display all element");
            IDictionaryEnumerator e = hDay.GetEnumerator();
            while (e.MoveNext())
            {
                Console.WriteLine(e.Key + "\t" + e.Value);
            }
            Console.WriteLine("------------");

            Console.Read();
        }
    }
}