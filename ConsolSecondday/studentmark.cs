using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class studentmark
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Registration number");
            int reginum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter of three Subject");
            Console.WriteLine("Subject1");
            int mark1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Subject2");
            int mark2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Subject2");
            int mark3 = Convert.ToInt32(Console.ReadLine());
            int Totalmarks = mark1 + mark2 + mark3;
            int Avemark = Totalmarks / 3;
            Console.WriteLine("\n Student details are as follows");
            Console.WriteLine($"Registration number :{reginum}");
            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"Total Marks:{Totalmarks}");
            Console.WriteLine($"Total Average mark:{Avemark}");
            Console.ReadLine();
        }
    }
}
