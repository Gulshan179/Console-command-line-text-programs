using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class Simplestructure
    {
        struct Books
        {
            public string title;
            public string author;
            public string subject;
            public int book_id;
            public float book_price;
            public char book_grade;
        }
        public static void Main()
        {
            Books Book1;
            Books Book2;
            Book1.title = "C Programming";
            Book1.author = "Nuha Ali";
            Book1.subject = "C Programming Tutorial";
            Book1.book_id = 6495407;
            Book1.book_price = 456.32f;
            Book1.book_grade = 'a';
            Book2.title = "C Programming";
            Book2.author = "Nuha Ali";
            Book2.subject = "C Programming Tutorial";
            Book2.book_id = 6495407;
            Book2.book_price = 456.32f;
            Book2.book_grade = 'a';
            Console.WriteLine("Book 1 title : {0}", Book1.title);
            Console.WriteLine("Book 1 author : {0}", Book1.author);
            Console.WriteLine("Book 1 subject : {0}", Book1.subject);
            Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);
            Console.WriteLine("Book 1 price : {0}", Book1.book_price);
            Console.WriteLine("Book 1 grade:{0}", Book1.book_grade);
            Console.WriteLine("Book 2 title : {0}", Book2.title);
            Console.WriteLine("Book 2 author : {0}", Book2.author);
            Console.WriteLine("Book 2 subject : {0}", Book2.subject);
            Console.WriteLine("Book 2 book_id :{0}", Book2.book_id);
            Console.WriteLine("Book 2 price : {0}", Book1.book_price);
            Console.WriteLine("Book 2 grade:{0}", Book1.book_grade);
            Console.ReadKey();
        }

    }
}
