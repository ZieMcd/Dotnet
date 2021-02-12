using System;

namespace Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {

            var book1 = new Book("Harry Potter","JK Rowling", 400);

            var book2 = new Book("Lord of the Rings","Tolkein",700);
          

            Console.WriteLine(book2.sTitle);
            Console.WriteLine(book1.sTitle);

            book2.sTitle = "The hobbit";
            Console.WriteLine(book2.sTitle);
        }
    }
}
