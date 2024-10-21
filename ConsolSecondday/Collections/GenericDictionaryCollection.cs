using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Collections
{
     class GenericDictionaryCollection
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> phone = new Dictionary<int, string>();
            phone.Add(1, "James");
            phone.Add(2, "Amit");
            phone.Add(3, "Kajol");

            phone[12] = "Abhishek";
            Console.WriteLine("is abhishek at 12th index? {0} ",
           phone[12].Contains("Abhishek"));
            Console.WriteLine("--------------------------------");
            Console.WriteLine("is taru at 12th index? {0} ", phone[12].Contains("taru"));
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1st index element {0}", phone[1]);

            if (!phone.ContainsKey(4))
            {
                phone.Add(4, "Ajinkhy");//add element at 4 position 
            }
            else
                Console.WriteLine("that is is allready exist");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(" 4th index element {0}", phone[2]);
            foreach (KeyValuePair<int, String> ph in phone)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                ph.Key, ph.Value);
                // Console.WriteLine("Key = {0}", 
                // ph.Key); 
                // Console.WriteLine(" Value = {0}", 
                // ph.Value); 
            }
            Console.Read();
        }
    }
}
