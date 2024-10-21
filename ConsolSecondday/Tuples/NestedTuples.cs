using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.Tuples
{
    class NestedTuples
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------Nested tuple-------------------------------");
            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
            Console.WriteLine(numbers.Item1);
            Console.WriteLine(numbers.Item7);
            Console.WriteLine(numbers.Rest.Item1);
            Console.WriteLine(numbers.Rest.Item1.Item1);
            Console.WriteLine(numbers.Rest.Item1.Item2);
            Console.WriteLine(numbers.Rest.Item1.Item6);
            Console.WriteLine("-------------------nested tuple object anywhere in the sequence-------------------------------");
            //nested tuple object anywhere in the sequence
            var numberes = Tuple.Create(1, 2,Tuple.Create(3,4,5,6,7,8),9,10,11,12,13);
            Console.WriteLine(numberes.Item1);
            Console.WriteLine(numberes.Item2);
            Console.WriteLine(numberes.Item3);
            Console.WriteLine(numberes.Item3.Item1);
            Console.WriteLine(numberes.Item4);
            Console.WriteLine(numberes.Rest.Item1);
            //Tuple Method Parameter
            Console.WriteLine("-------------------Tuple method Parameter-------------------------------");
            //Tuple method Parameter
            var person = Tuple.Create(1, "Gulshan", "Chauhan");
            //Console.WriteLine(person.Item1);
            //Console.WriteLine(person.Item2);
            //Console.WriteLine(person.Item3);
            DisplayTuple(person);
            Console.WriteLine("-------------------Value Tuple Without name member-------------------------------");
            //Value Tuple Without name member
            ValueTuple<int, string, string> person1 = (1, "Bill", "Gates");
            Console.WriteLine(person1.Item1);
            Console.WriteLine(person1.Item2);
            Console.WriteLine(person1.Item3);
            (int, string, string) person2 = (1, "James", "Bond");
            Console.WriteLine(person2.Item1);
            Console.WriteLine(person2.Item2);
            Console.WriteLine(person2.Item3);
            Console.WriteLine("-------------------Value Tuple With name member-------------------------------");
            //Value Tuple With name member
            (int id, string firsname, string lastname) person3 = (1, "Roshan", "Chauhan");
            Console.WriteLine(person3.id);
            Console.WriteLine(person3.firsname);
            Console.WriteLine(person3.lastname);
            Console.WriteLine("-------------------Value Tuple as Parameter-------------------------------");
            //Value Tuple as Parameter
            DisplayTup1((1, "Bill", "Gets"));
            Console.WriteLine("----------------------Value Tuple as Return Type----------------------------");
            //Value Tuple as Parameter return
            var person4 = Getperson();
            Console.WriteLine("{0},{1},{2}",person4.Item1,person4.Item2,person4.Item3);
            Console.WriteLine("----------------------specify member names for a ValueTuple returned from the method.----------------------------");
            //specify member names for a ValueTuple returned from the method
            var person6= GetPerson1();
            Console.WriteLine("{0},{1},{2}",person6.id,person6.firstname,person6.lastname);
            Console.WriteLine("Enter Day");
            string day = Console.ReadLine();
            string Message = string.Empty;

            switch (day.ToUpper())
            {
                case "Sunday":
                    Message = "Weekend";
                    break;
                case "Monday":
                    Message = "start of the Weekday";
                    break;
                case "Friday":
                    Message = "End of the Weekday";
                    break;
                default:
                    Message = "Invalid Day";
                    break;

            }
            Console.WriteLine($"{day} is {Message}");
            //Console.ReadLine();



            Console.ReadLine();
        }

        static void DisplayTuple(Tuple<int,string,string>person)
        {
            Console.WriteLine($"id={person.Item1}");
            Console.WriteLine($"First name={person.Item2}");
            Console.WriteLine($"Last name={person.Item3}");
            Console.ReadLine();

        }
        static void DisplayTup1((int, string, string) person5)
        {
            Console.WriteLine("{0},{1},{2}", person5.Item1, person5.Item2, person5.Item3);
        }
        static (int,string,string) Getperson()
        {
            return (1, "Rishi", "Yadav");
        }
        static (int id,string firstname, string lastname) GetPerson1()
        {
            return (id: 1, firstname: "Shivam", lastname: "Yadav");
        }
    }
}
