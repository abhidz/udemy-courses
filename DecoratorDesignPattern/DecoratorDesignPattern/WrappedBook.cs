using System;
using System.Collections.Generic;
using System.Text;

// Decorator class
namespace DecoratorDesignPattern
{
    public class WrappedBook : Book
    {
        private Book _book;
        public WrappedBook(Book book)
        {
            this._book = book;
        }

        public override int SetDimension(int lenth, int breadth, int height)
        {
            return lenth * breadth * height * 10;
        }
        public override void Display()
        {
            Console.WriteLine(_book.Title.ToUpper());
        }
    }
}
