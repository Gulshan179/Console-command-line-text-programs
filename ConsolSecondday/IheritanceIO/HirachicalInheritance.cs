using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.IheritanceIO
{
    
    public class HirachicalInheritance
    {
        public void attedEvents()
        {
            Console.WriteLine("Attending Events");
        }
        public void Attendance()
        {
            Console.WriteLine("Giving Attendance");
        }
        public void Holiday()
        {
            Console.WriteLine("Giving Holidaylist");
        }
       
    }
    class festStudent: HirachicalInheritance
    {
        public void Socialactivity()
        {
            Console.WriteLine("Socaial Activity events ");
        }
    }
    class seStudent: HirachicalInheritance
    {
        public void tracking()
        {
            Console.WriteLine("Attending Tracking");
        }
    }
    class testStudent: HirachicalInheritance
    {
        public void PlacementPraparation()
        {
            Console.WriteLine("Placement Prapration");
        }
    }
    class bestStudent : HirachicalInheritance
    {
        public void Project()
        {
            Console.WriteLine("Project Events");
        }
    }
    class mainStudent2
    {
        public static void Main(string[] args)
        {
            festStudent f1 = new festStudent();
            f1.attedEvents();
            f1.Attendance();
            f1.Holiday();
            f1.Socialactivity();

            seStudent s1 = new seStudent();
            s1.attedEvents();
            s1.Attendance();
            s1.Holiday();
            s1.tracking();

            testStudent t1 = new testStudent();
            t1.attedEvents();
            t1.Attendance();
            t1.Holiday();
            t1.PlacementPraparation();


            bestStudent b1 = new bestStudent();
            b1.attedEvents();
            b1.Attendance();
            b1.Holiday();
            b1.Project();

            Console.ReadLine();
        }
    }

}
