using System;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.Title = "nagaraj";
            book.Display();
            Console.WriteLine(book.SetDimension(1, 2, 3));

            Console.WriteLine("Ater applying decorator pattern");

            var decorator = new WrappedBook(book); // Calling decorator pattern
            decorator.Display();
            Console.WriteLine(decorator.SetDimension(1, 2, 3));
            Console.ReadLine();
        }
    }
}
