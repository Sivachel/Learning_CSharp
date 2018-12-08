using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Without using a Constructor
            Book book1 = new Book(); //object is an instance of a class
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book(); 
            book2.title = "Lord of the Rings";
            book2.author = "Tolkein";
            book2.pages = 700;
            */

            // With using a constructor in a class
            Book book1 = new Book("Harry Potter", "JK Rowling", 400); 
            Book book2 = new Book("Lord of the Rings","Tolkein", 700);
            book2.title = "The Hobbit"; //to access and change a string in the contructor 


            Console.WriteLine(book2.title);
            Console.ReadLine();
        }
    }
}
