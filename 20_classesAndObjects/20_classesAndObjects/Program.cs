using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_classesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(); //object is an instance of a class
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book(); //object is an instance of a class
            book2.title = "Lord of the Rings";
            book2.author = "Tolkein";
            book2.pages = 700;

            Console.WriteLine(book2.author);
            Console.ReadLine();
        }
    }
}
