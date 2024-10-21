using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.IheritanceIO
{
   class Squad
    {
        public void Squad_info()
        {
            Console.WriteLine("Class Info");
        }
        public void Placement_info()
        {
            Console.WriteLine("PlacementInfo");
        }
    }
    class SquadThane:Squad
    {
        public void Thane_branch_info()
        {
            Console.WriteLine("Thane Branch Inforamation");
        }
        public void Thane_branch_staff_Info()
        {
            Console.WriteLine("Thane branch Staff information");
        }

    }
    class Vashibranch:Squad
    {
        public void Vashi_branch_info()
         {
            Console.WriteLine("Vashi Branch Information");
        }
        public void Vashi_branch_staff_Info()
        {
            Console.WriteLine("Vashi branch Staff information");
        }

    }
    class Student:SquadThane
    {
        public void Student_info()
        {
            Console.WriteLine("Student inforamation");
        }
        static void Main(string[] args)
        {
            Student st = new Student();
            st.Squad_info();
            st.Placement_info();
            st.Thane_branch_info();
            st.Thane_branch_staff_Info();
            Console.ReadLine();           
            // st.Vashi_branch_info(); //Does not use because of vashi another class
        }

    }
}
