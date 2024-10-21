    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsolSecondday
    {
        internal class Classmethod
        {
            int roll_no;
            string name;
            string address;
            float marks;
            double grade;
            bool cap;
        
            void getinfo()
            {
                Console.WriteLine("Enter Your Roll  no");
                roll_no=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Your Name");
                name = Console.ReadLine();

                Console.WriteLine("Enter Your address");
                address = Console.ReadLine();

                Console.WriteLine("Enter Your marks");
                marks=Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter your grade");
                grade = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("You have done cap raound or not");
                cap = Convert.ToBoolean(Console.ReadLine());

            }
        
            void showinfo()
            {
                Console.WriteLine("Roll  no is ",roll_no);
                Console.WriteLine("Name is", name);
                Console.WriteLine("Address", address);
                Console.WriteLine("Marks is", marks);
                Console.WriteLine("Grade is", grade);
                Console.WriteLine("I have done cap round", cap);
            }
            static void Main(string[] args)
            {
                Classmethod s1 = new Classmethod();
                Classmethod s2 = new Classmethod();
                s1.getinfo();
                s1.showinfo();
                s2.getinfo();
                s2.showinfo();
                Console.ReadLine();
            }
        }
    }
