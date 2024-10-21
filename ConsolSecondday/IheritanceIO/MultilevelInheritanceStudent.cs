using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.IheritanceIO
{
     class MultilevelInheritanceStudent
    {
        public void attendevents()
        {
            Console.WriteLine("Attending events");

        }
        public void attendance()
        {
            Console.WriteLine("Giving Attandance");
        }
        public void Holiddaylist()
        {
            Console.WriteLine("Giving Holidaylist");
        }
    }
      class ITperatmentStudent:MultilevelInheritanceStudent
    {
        public void HODName()
        {
            Console.WriteLine("Atul Sir");
        }
    }

     class FirstdepartmentStd: ITperatmentStudent
    {
        public void studyrTFeitStd()
        {
            Console.WriteLine("Do study relate feit subject");
        }
      
         static void main(string[] args)
        {
            FirstdepartmentStd f1=new FirstdepartmentStd();
            f1.attendance();
            f1.attendevents();
            f1.Holiddaylist();
            f1.HODName();
            f1.studyrTFeitStd();
            Console.ReadLine();
        }
        }
   

}
