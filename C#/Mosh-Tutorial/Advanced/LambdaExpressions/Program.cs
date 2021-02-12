using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int> Sqaure = number => number * number;
            //System.Console.WriteLine(Sqaure(5));
            //var test = Console.Readline();
            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                System.Console.WriteLine(book.Title);
            }

        }
    }
}
