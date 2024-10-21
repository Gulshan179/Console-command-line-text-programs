using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday
{
    internal class simple_structur
    {
        struct books
        {
            public string title;
            public string author;
            public string subject;
            public int boo_id;
            public float price;
            public char book_grade;

        };
        static void Main(string[] args)
        {
            books book1;
            books book2;


            book1.title = "C Programming";
            book1.author = "Gulshan Chauhan";
            book1.subject = "C Programming Tutorial";
            book1.boo_id = 34;
            book1.price = 343.3f;
            book1.book_grade = 'a';

            book2.title = "C Programming";
            book2.author = "Gulshan Chauhan";
            book2.subject = "C Programming Tutorial";
            book2.boo_id = 34;
            book2.price = 343.3f;
            book2.book_grade = 'a';


            Console.WriteLine("Book1 title{0}", book1.title);
            Console.WriteLine("Book1 author{0}", book1.author);
            Console.WriteLine("Book1 subject{0}", book1.subject);
            Console.WriteLine("Book1   book id{0}", book1.boo_id);
            Console.WriteLine("Book1 price is{0}", book1.price);
            Console.WriteLine("Book1 GRADEIS{0)", book1.book_grade);

            Console.WriteLine("book2 title{0}", book2.title);
            Console.WriteLine("book2 author{0}", book2.author);
            Console.WriteLine("book2 subject{0}", book2.subject);
            Console.WriteLine("book2   book id{0}", book2.boo_id);
            Console.WriteLine("book2 price is{0}", book2.price);
            Console.WriteLine("Book2 GRADEIS{0)", book2.book_grade);

            Console.ReadKey();


        }
    }
}
